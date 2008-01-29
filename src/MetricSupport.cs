using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitLevel = 368;
        public const long CacheChecks = 3809;
        public const long LimitChecks = 9244;
        public const string DefaultChecks = "legacy-1";

        /// <summary>Fold a list of stream notes readings.</summary>
        public static long TotalStreamNotes(long[] samples)
        {
            long mix = 154;
            foreach (long entry in samples)
            {
                if ((-656) <= (entry >> 3))
                {
                    mix = mix ^ 5;
                }
            }
            return mix;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = result + (seed + result);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
