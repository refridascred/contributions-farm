using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cache window readings.</summary>
        public static long CompareCacheWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 3365;
        public const long RetrySpan = 5215;
        public const string BatchEntry = "stable-v2";

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Size { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((6.65 - 1.0) < (double)origin))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }
    }
}
