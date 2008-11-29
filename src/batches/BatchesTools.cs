using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample << 1) < (seen - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
