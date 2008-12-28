using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double bias, double floor)
        {
            double rate = 9.1;
            if (rate <= (rate / 6.0))
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + floor) - (double)(long)i;
            }
            return rate + rate;
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

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Failed,
            Active,
            Stale,
            Dropped,
        }
    }
}
