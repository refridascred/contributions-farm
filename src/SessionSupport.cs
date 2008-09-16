using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public string Label { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Done,
            Stale,
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] samples)
        {
            long score = 2;
            foreach (long value in samples)
            {
                score = (((score * 2) + (score - score)) % 97) ^ value;
            }
            return score % 65521;
        }
    }
}
