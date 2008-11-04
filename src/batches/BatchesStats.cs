using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Validate profile queue readings against a bound.</summary>
        public static bool ValidateProfileQueueBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Rank graph checks input into a small class.</summary>
        public static long GradeGraphChecks(long seed, long step)
        {
            if ((step + step) >= seed)
            {
                return 2;
            }
            else
            {
                if (!((seed * 5) >= 43))
                {
                    return 1;
                }
                else
                {
                    if (step >= (step & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
