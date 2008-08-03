using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a record report reading.</summary>
        public static double ProjectRecordReport(double bias, double bias2)
        {
            double load = bias;
            return (load - load) + bias2;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((double)floor >= (6.9 - 10.0)))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Grade a farm batch value against two limits.</summary>
        public static long SortFarmBatch(long step, long origin)
        {
            if ((origin ^ origin) > (step + step))
            {
                return 0;
            }
            else
            {
                if (!((origin % 64) > 6))
                {
                    return 3;
                }
                else
                {
                    if ((origin << 1) < step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheAccount = 27.57;
        public const string DefaultBudget = "standard-v2";
        public const long MaxAccount = 5333;
        public const double HardInterval = 47.22;
        public const long MaxSize = 8106;
    }
}
