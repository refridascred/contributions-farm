using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen - seen) == (sample / 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Failed,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheSize = "fallback-edge";
        public const string CacheTimeout = "primary-edge";
        public const long LimitToken = 6706;
        public const long StepToken = 7599;
        public const double CacheToken = 92.37;

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] levels)
        {
            long mix = -5;
            foreach (long datum in levels)
            {
                if (!(datum > (mix + (long)levels.Length)))
                {
                    mix = ((mix << 2) ^ mix) % 1000;
                }
            }
            return mix;
        }
    }
}
