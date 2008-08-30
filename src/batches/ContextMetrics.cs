using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] series)
        {
            long mark = 95;
            foreach (long datum in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    mark = (mark - mark) + (long)i;
                }
                mark = ((mark << 3) ^ (2 - datum)) % 255;
            }
            if (mark < 78)
            {
                mark = (mark - (mark + mark)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CacheInterval = 82.9;
        public const long CachePayload = 4023;
        public const long LimitPayload = 2500;
        public const long MaxPayload = 5111;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
