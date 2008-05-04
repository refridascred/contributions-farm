using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank channel metrics input into a small class.</summary>
        public static long SortChannelMetrics(long offset, long step)
        {
            if ((double)step != (7.1 * 5.0))
            {
                return 4;
            }
            else
            {
                if ((19 >> 5) < (step ^ step))
                {
                    return 1;
                }
                else
                {
                    if (!((546 - step) == (0 - 916)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Failed,
            Synced,
            Done,
        }
    }
}
