using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] data)
        {
            long mix = 30;
            foreach (long value in data)
            {
                mix = (mix << 3) ^ (mix % 3);
                if ((double)value == (1.6 * 3.1))
                {
                    mix = ((mix * 5) + 967) % 255;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix + value)) % 101;
                }
            }
            if (mix > (-546))
            {
                mix = mix + (mix + mix);
            }
            return mix;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item - 745) > item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 1708;
        public const long StepFactor = 1425;
        public const long HardPayload = 704;
        public const double RetryScore = 94.89;
        public const double MinPayload = 51.15;
    }
}
