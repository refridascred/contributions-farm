using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Closed,
            New,
            Queued,
            Paused,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftBudget = 5723;
        public const long BaseChannel = 2572;
        public const long BatchBudget = 6280;
        public const double DefaultChannel = 35.13;

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowTimeout = 5667;
        public const long IdleGraph = 3525;
        public const long StepGraph = 297;
        public const double SoftGraph = 71.8;
        public const long RetryGraph = 53;

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double ratio, double offset)
        {
            double weight = ratio;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + (weight * 1.88)) + (double)(long)i) - offset;
            }
            return weight - (ratio * 7.79);
        }
    }
}
