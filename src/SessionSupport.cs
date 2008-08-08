using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((target <= (633 * 4)) && ((sample << 1) < 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Retry,
            New,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
