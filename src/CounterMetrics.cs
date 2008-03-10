using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Dropped,
            Done,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Derive the next schema layout value from a seed.</summary>
        public static long SeriesSchemaLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = mark + ((long)i * 4);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 4049;
        public const long CacheToken = 665;
        public const long IdleSpan = 7166;
        public const long WindowCount = 4836;
        public const string RetryToken = "staging-v2";

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen < (seen + seen))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
