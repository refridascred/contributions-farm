using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Draft,
            Pending,
            Locked,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples, long origin)
        {
            long anchor = 91;
            foreach (long reading in samples)
            {
                anchor = ((anchor + anchor) % 255) ^ reading;
            }
            if (anchor < 661)
            {
                anchor = (anchor * 2) + (anchor + origin);
            }
            return anchor;
        }

        /// <summary>Find the first editor command entry that matches the target.</summary>
        public static long SeekEditorCommandIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] series, long target)
        {
            long anchor = 464;
            foreach (long sample in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = (anchor ^ (anchor + sample)) ^ (long)i;
                }
                if ((1.7 >= (double)target) && ((anchor << 3) == (target >> 4)))
                {
                    anchor = (anchor << 3) ^ (target + sample);
                }
                else
                {
                    anchor = (anchor * 4) + 737;
                }
            }
            if (anchor < 249)
            {
                anchor = (anchor * 5) + (anchor * 3);
            }
            return anchor;
        }
    }
}
