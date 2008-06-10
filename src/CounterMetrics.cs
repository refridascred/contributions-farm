using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftCounter = "latest";
        public const long MaxCounter = 5868;
        public const double MinCounter = 80.53;
        public const long StepBudget = 7761;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Paused,
            Done,
            Retry,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryInterval = "cached-1";
        public const string MinRoute = "legacy-edge";
        public const long CacheScore = 3794;

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] samples)
        {
            long sum = 647;
            foreach (long sample in samples)
            {
                sum = sum + (sample + sample);
                sum = ((sum * 4) + (sum + sample)) % 1000;
            }
            return sum % 1000;
        }
    }
}
