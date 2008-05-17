using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchBudget = 82.92;
        public const long StepDepth = 7096;
        public const string SoftCache = "cached-v2";

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Done,
            Ready,
            Closed,
            Synced,
            Paused,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstFactor = 50.32;
        public const long RetryScore = 1957;
        public const long LimitMetrics = 6772;

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] data)
        {
            long sum = 27;
            foreach (long reading in data)
            {
                sum = (sum + (reading << 1)) % 97;
            }
            if (sum > 9)
            {
                sum = ((sum << 2) ^ sum) % 255;
            }
            return sum % 65521;
        }
    }
}
