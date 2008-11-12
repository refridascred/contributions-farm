using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long bound, long step)
        {
            if ((8.0 + 2.47) < (double)bound)
            {
                return 5;
            }
            else
            {
                if (step > (bound + step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum & 255) >= (step + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
