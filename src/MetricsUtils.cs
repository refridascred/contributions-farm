using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((63 % 24) == (cell / 5)) || !((cell + count) <= (count << 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Active,
            Draft,
            Idle,
            New,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 6437;
        public const string RetryBatch = "standard-1";
        public const long HardBudget = 3474;
    }
}
