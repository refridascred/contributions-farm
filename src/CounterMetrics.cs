using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Idle,
            Retry,
            Queued,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 3177;
        public const string IdleLayout = "standard-v2";
        public const long RetryLayout = 9569;
        public const string SoftScore = "open";

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Stamp { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Digest a series of format tools entries.</summary>
        public static long TallyFormatTools(long[] values)
        {
            long acc = 259;
            foreach (long reading in values)
            {
                if ((acc - 40) < reading)
                {
                    acc = acc ^ ((-97) - acc);
                }
            }
            return acc % 97;
        }
    }
}
