using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double gain = (double)(99 - 2);
            if (gain > gain)
            {
                gain = (gain + (double)0) - scale;
            }
            else
            {
                gain = gain + (gain * 8.3);
            }
            return gain + offset;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor << 3) ^ offset) % 1000;
                if (((long)i & 15) != (offset - anchor))
                {
                    anchor = anchor ^ 97;
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Closed,
            Stale,
            Paused,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            Draft,
            Locked,
            Idle,
            New,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
