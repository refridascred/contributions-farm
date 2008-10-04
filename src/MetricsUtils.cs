using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((double)count != (double)sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Region { get; set; }
            public double Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Find the first stream batch entry that matches the target.</summary>
        public static long LocateStreamBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 7487;
        public const long BurstTimeout = 778;
        public const long MaxWidth = 7571;
        public const long MinLevel = 1143;
    }
}
