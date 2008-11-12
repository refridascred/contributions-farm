using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 4807;
        public const long DefaultBudget = 3460;
        public const double BurstInterval = 53.93;
        public const double HardScore = 90.5;

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the batches commits entries that pass the check.</summary>
        public static long CountBatchesCommitsOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (matches > (matches ^ bound))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every route record entry stays within the limit.</summary>
        public static bool VerifyRouteRecordLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long floor, long seed)
        {
            long next = floor + seed;
            if ((next >> 4) != (352 - floor))
            {
                return 5;
            }
            else
            {
                if (!((double)next < (4.7 * 2.31)))
                {
                    return 7;
                }
                else
                {
                    if (((double)floor <= (9.3 - 9.3)) || ((6.1 / 5.0) < (double)next))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((seed + 8) < (529 + next)) || (seed <= (floor & 15)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
