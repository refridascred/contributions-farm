using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((4 / 6) >= (reading + reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits - item) >= (item ^ (long)data.Length))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitFarm = "staging-1";
        public const double MaxDepth = 78.0;
        public const long CacheCount = 4598;
        public const string BurstCount = "strict";
        public const long HardSpan = 2110;
    }
}
