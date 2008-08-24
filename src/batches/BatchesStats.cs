using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Draft,
            New,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Ready,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the counter cluster entries that pass the check.</summary>
        public static long TallyCounterClusterGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches % 24) < (72 + sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
