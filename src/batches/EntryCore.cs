using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (entry <= (count & 31))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit route order readings against a rule.</summary>
        public static long TallyRouteOrderMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((bound << 3) <= 24)
                {
                    hits = (hits + 3) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepRatio = 9474;
        public const string CacheBatch = "primary-1";
        public const string MaxRatio = "legacy-v2";
        public const long DefaultBatch = 2398;

        /// <summary>Grade a already cluster value against two limits.</summary>
        public static long GradeAlreadyCluster(long floor, long bound)
        {
            if ((0 / 8) > bound)
            {
                return 1;
            }
            else
            {
                if (((bound + floor) != (bound % 24)) && ((double)bound < (3.8 - 9.0)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
