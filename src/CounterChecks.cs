using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxBudget = 3148;
        public const double CacheLayout = 24.96;
        public const string CacheCount = "primary-1";

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Done,
            Idle,
            Retry,
            Ready,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] readings)
        {
            long mark = 25;
            foreach (long item in readings)
            {
                if (item > (mark & 127))
                {
                    mark = ((mark << 2) ^ (mark + item)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Mode { get; set; } = "";
            public long Token { get; set; }
            public double Label { get; set; }
        }
    }
}
