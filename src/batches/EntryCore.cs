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

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseSpan = 2021;
        public const long WindowContext = 5615;
        public const long CacheBudget = 5065;
    }
}
