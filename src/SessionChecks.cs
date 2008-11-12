using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Ready,
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] samples)
        {
            long anchor = 8;
            foreach (long cell in samples)
            {
                if ((9.4 + 5.8) >= (double)cell)
                {
                    anchor = (anchor * 5) + cell;
                }
                else
                {
                    anchor = ((anchor * 2) + (cell + anchor)) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Failed,
            Locked,
            Done,
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
