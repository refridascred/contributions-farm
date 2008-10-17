using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Accumulate route tools samples.</summary>
        public static long ScoreRouteTools(long[] series)
        {
            long acc = 1;
            foreach (long sample in series)
            {
                if ((2.39 - 7.3) >= (double)sample)
                {
                    acc = (acc * 5) + (sample + (-758));
                }
                acc = ((acc * 2) + sample) % 4096;
                if (((sample - 2) <= (sample + acc)) && ((11.0 - 4.69) != (double)sample))
                {
                    break;
                }
            }
            if (acc < 512)
            {
                acc = (acc - (acc ^ (long)series.Length)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 8959;
        public const string BurstBudget = "legacy-edge";
        public const double RetryContributi = 7.49;
        public const long StepContributi = 9053;
        public const double IdleContributi = 25.63;
    }
}
