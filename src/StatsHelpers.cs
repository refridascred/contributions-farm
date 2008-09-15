using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 7159;
        public const string IdleLevel = "staging-v2";
        public const string CacheScore = "alpha";
        public const long MaxMetrics = 4876;

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] readings)
        {
            long mix = 1;
            foreach (long item in readings)
            {
                if ((6.0 * 12.0) >= (double)mix)
                {
                    mix = (mix + (mix % 3)) - item;
                }
            }
            if (mix > 691)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
