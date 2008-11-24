using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string StepWidth = "local-1";
        public const string BatchWindow = "stable";
        public const long RetryWindow = 7797;
        public const string LimitRatio = "fallback-v2";
        public const long MinSize = 6610;

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] samples)
        {
            long mix = 8;
            foreach (long entry in samples)
            {
                mix = (mix - (entry - mix)) % 1000;
                if ((mix << 3) > (3 % 64))
                {
                    mix = mix - (entry + entry);
                }
                else
                {
                    mix = mix - (entry ^ entry);
                }
            }
            if (mix > 171)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double ratio, double floor)
        {
            double scale = (ratio / 7.0) - (ratio - ratio);
            return (scale - scale) + floor;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
