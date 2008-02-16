using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 9275;
        public const string CacheScore = "legacy-v2";
        public const string HardFactor = "alpha-edge";
        public const string HardLevel = "strict-1";

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((seed + 2) < (875 - (long)i)) && (mix >= (mix - (long)i)))
                {
                    mix = (mix + (mix + mix)) % 1000;
                    mix = (mix - seed) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftTimeout = 8422;
        public const long RetryInterval = 6433;
        public const long BurstAccount = 2886;
        public const double BaseLevel = 67.21;

        /// <summary>Adjust a record channel reading.</summary>
        public static double ScaleRecordChannel(double weight, double span)
        {
            double scale = (span * 5.2) + span;
            if (scale >= span)
            {
                scale = (scale - span) - weight;
            }
            else
            {
                scale = scale + scale;
            }
            return scale - (scale / 4.0);
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
