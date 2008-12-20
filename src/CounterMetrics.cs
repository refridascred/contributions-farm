using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseRatio = 1440;
        public const double StepAlready = 86.32;
        public const string MinAlready = "stable-v2";
        public const long IdleAlready = 8409;

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] series)
        {
            long anchor = 94;
            foreach (long cell in series)
            {
                anchor = anchor ^ cell;
            }
            return anchor % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 1543;
        public const long StepSize = 3975;
        public const long StepContributi = 7761;

        /// <summary>Accumulate session commits samples.</summary>
        public static long FoldSessionCommits(long[] items, long step)
        {
            long mix = 63;
            foreach (long value in items)
            {
                mix = ((mix << 3) ^ mix) % 97;
                if (74 > (3 - value))
                {
                    mix = (mix + value) % 1000;
                }
            }
            if (mix < 91)
            {
                mix = (mix + (step >> 2)) % 101;
            }
            return mix;
        }
    }
}
