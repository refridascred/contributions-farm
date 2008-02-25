using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count graph session pairs that satisfy a relation.</summary>
        public static long MatchGraphSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
