using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Paused,
            Failed,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Synced,
            Retry,
            Done,
            Paused,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = ((result + (result + result)) % 255) ^ (long)i2;
                }
                result = ((result * 4) + (30 - limit)) % 65521;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((double)total >= (double)3)
                {
                    total = (total << 2) ^ (total ^ floor);
                    total = total - (total * 4);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
