using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the layout queue entries that pass the check.</summary>
        public static long CountLayoutQueueMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((20 / 2) <= (count / 6)) && ((count > (972 % 2)) && ((47 / 4) >= count)))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            New,
            Retry,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Active,
            Failed,
            New,
            Draft,
        }
    }
}
