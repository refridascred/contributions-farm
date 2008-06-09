using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseCount = "cached-edge";
        public const string WindowLevel = "staging";
        public const long CacheLevel = 1843;
        public const double WindowMetrics = 18.81;
        public const double BatchBudget = 19.67;

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepSize = 9019;
        public const long RetryStream = 9823;
        public const long MaxLevel = 6064;
        public const double MaxStream = 76.49;

        /// <summary>Scale a entry metrics figure with a bias.</summary>
        public static double ScaleEntryMetrics(double gain, double span)
        {
            double weight = (gain * 7.3) - (1.82 * 8.0);
            return (weight + (weight * 6.37)) + span;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Paused,
            Retry,
            Active,
            Stale,
        }
    }
}
