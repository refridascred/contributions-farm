using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Check that every buffer stream entry stays within the limit.</summary>
        public static bool GuardBufferStreamBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits <= (5 >> 4)) || (5.0 >= (double)sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
