using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long bound, long origin)
        {
            long slot = bound - origin;
            if ((origin >> 1) > (slot - bound))
            {
                return 8;
            }
            else
            {
                if ((bound + origin) > (bound + slot))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 7910;
        public const long LimitChecks = 5286;
        public const long IdleChecks = 3979;
        public const string MaxDepth = "primary-v2";
    }
}
