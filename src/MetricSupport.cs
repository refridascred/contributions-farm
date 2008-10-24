using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstSize = "legacy-edge";
        public const string CacheScore = "fallback";
        public const string IdleContributi = "latest";
        public const string BurstSpan = "standard-1";

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double gain, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (gain + gain)) + (double)(long)i;
            }
            return scale + (double)233;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
