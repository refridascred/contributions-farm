using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSize = 7103;
        public const string IdleTimeout = "stable-v2";
        public const long LimitTimeout = 578;
        public const long RetryWidth = 2291;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Locked,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double ratio, double floor)
        {
            double weight = ratio;
            return weight + floor;
        }
    }
}
