using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Rank { get; set; } = "";
            public long Size { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Active,
            Closed,
            Paused,
            Draft,
            Pending,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits + origin) >= sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
