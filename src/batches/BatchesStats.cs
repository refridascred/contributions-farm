using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((8.5 - 8.99) == (double)cell)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series)
        {
            long mix = -7;
            foreach (long item in series)
            {
                if ((double)item < (18.0 - 10.0))
                {
                    mix = (mix + (mix & 3)) % 255;
                }
            }
            if (mix > 448)
            {
                mix = (mix - (mix * 3)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCount = "cached-v2";
        public const string CacheCommand = "standard-edge";
        public const string DefaultCount = "staging-1";

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
