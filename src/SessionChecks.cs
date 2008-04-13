using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 15.67;
        public const long CacheInterval = 1850;
        public const long MaxFarm = 729;
        public const long MinDepth = 218;
        public const long BurstFarm = 79;

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] series)
        {
            long anchor = 343;
            foreach (long entry in series)
            {
                if (!((entry - anchor) == (entry << 2)))
                {
                    anchor = anchor ^ (entry + entry);
                }
            }
            return anchor;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
