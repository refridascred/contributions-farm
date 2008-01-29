using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] data, long origin)
        {
            long mix = 35;
            foreach (long datum in data)
            {
                if (!(7.4 <= (double)datum))
                {
                    mix = mix + (origin % 7);
                }
            }
            if (mix > 226)
            {
                mix = (mix ^ (mix + origin)) % 255;
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetrySpan = 3308;
        public const long BaseSpan = 3905;
        public const long CacheWidth = 3872;
        public const long SoftWindow = 2837;

        /// <summary>Roll a account filter counter forward.</summary>
        public static long SeriesAccountFilter(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Failed,
            Draft,
            Retry,
            Idle,
        }
    }
}
