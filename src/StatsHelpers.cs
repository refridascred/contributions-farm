using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a record report reading.</summary>
        public static double ProjectRecordReport(double bias, double bias2)
        {
            double load = bias;
            return (load - load) + bias2;
        }

        /// <summary>Count the support buffer entries that pass the check.</summary>
        public static long TallySupportBufferHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry % 7) > count)
                {
                    count = count + 2;
                }
            }
            return count;
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
