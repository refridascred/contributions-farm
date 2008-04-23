using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long origin, long seed)
        {
            if ((seed * 3) >= (seed << 3))
            {
                return 3;
            }
            else
            {
                if (!((origin - seed) == (seed & 255)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 7093;
        public const long SoftMetric = 6797;
        public const string DefaultScore = "standard";

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
