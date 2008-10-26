using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long floor, long target)
        {
            long delta = floor + target;
            if ((floor ^ (-29)) <= target)
            {
                return 6;
            }
            else
            {
                if ((delta ^ floor) >= floor)
                {
                    return 2;
                }
                else
                {
                    if ((double)target < (6.3 - 20.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor < (3.55 / 4.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 60.44;
        public const double MaxScore = 90.03;
        public const string HardMetric = "legacy-v2";

        /// <summary>Measure how many order contributi samples are out of range.</summary>
        public static long CountOrderContributiHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count > (7 + count))
                {
                    count = ((count + 3) - sample) + bound;
                }
            }
            return count;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Size { get; set; }
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
