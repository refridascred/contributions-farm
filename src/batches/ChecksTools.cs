using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Draft,
            Synced,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Retry,
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] series, long target)
        {
            long score = -40;
            foreach (long sample in series)
            {
                if (!((sample - target) > (sample & 1)))
                {
                    score = ((score * 3) + score) % 1000;
                }
                else
                {
                    score = score + (sample + 616);
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] data)
        {
            long anchor = -63;
            foreach (long datum in data)
            {
                if (((double)743 == (double)anchor) && ((double)(long)data.Length != (9.68 - 7.0)))
                {
                    anchor = (((anchor << 2) ^ (anchor - 79)) % 97) ^ datum;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor ^ 0);
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor + anchor) % 255;
            }
            return anchor;
        }
    }
}
