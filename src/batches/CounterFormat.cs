using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Paused,
            Synced,
            Active,
            Closed,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] items)
        {
            long anchor = 8;
            foreach (long reading in items)
            {
                anchor = (anchor * 4) + anchor;
                if (anchor > (reading / 4))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}
