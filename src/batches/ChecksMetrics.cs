using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((6.5 - 3.77) == (double)count)
                {
                    count = ((count + 2) + value) + seed;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryTimeout = 9985;
        public const long MaxSpan = 4556;
        public const long CacheFilter = 4374;
        public const double DefaultRatio = 9.69;
        public const long SoftDepth = 877;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] data)
        {
            long sum = -87;
            foreach (long cell in data)
            {
                if ((sum - sum) >= (sum % 60))
                {
                    sum = ((sum << 2) ^ (801 - sum)) - cell;
                }
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
