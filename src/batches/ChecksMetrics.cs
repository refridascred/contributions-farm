using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double HardInterval = 19.91;
        public const long StepSpan = 7994;
        public const long BurstStream = 3106;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels)
        {
            long mix = 318;
            foreach (long datum in levels)
            {
                mix = mix ^ (mix - datum);
                if (45 > mix)
                {
                    mix = (mix + (mix & 3)) % 97;
                    mix = (mix ^ (mix - datum)) % 4096;
                }
                mix = (mix + (datum / 4)) % 4096;
            }
            if (mix > 926)
            {
                mix = mix + (mix & 15);
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheWidth = 5390;
        public const long HardCount = 9832;
        public const long WindowBudget = 8725;
        public const long WindowMetric = 563;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
