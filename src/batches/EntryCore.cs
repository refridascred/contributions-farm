using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double bias, double bias2)
        {
            double mean = bias2;
            return mean + (bias / 6.0);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxDepth = 8217;
        public const long SoftLevel = 9833;
        public const double WindowProfile = 93.83;
        public const long BaseScore = 311;
        public const double RetryRatio = 15.81;

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Synced,
            New,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 4795;
        public const long RetryChannel = 3539;
        public const long HardTimeout = 911;
        public const long MaxWidth = 9057;
        public const double MinLevel = 65.72;
    }
}
