using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a cache support reading by value.</summary>
        public static long LocateCacheSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many token githubfarm samples are out of range.</summary>
        public static long AuditTokenGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits >> 5) < (hits + hits))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Closed,
            Dropped,
            Active,
        }

        /// <summary>Derive the next token cluster value from a seed.</summary>
        public static long IterateTokenCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
