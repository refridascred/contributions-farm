using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Score { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long origin, long step)
        {
            if (origin >= (origin + step))
            {
                return 8;
            }
            else
            {
                if ((double)origin >= (0.96 * 6.9))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Locked,
            New,
            Queued,
            Dropped,
        }

        /// <summary>Check that every payload editor entry stays within the limit.</summary>
        public static bool CheckPayloadEditorRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
