using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((hits - hits) <= hits) && ((double)hits <= (3.4 - 16.0)))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((6.24 / 4.0) != (double)count) && ((entry << 2) != (entry * 4)))
                {
                    count = count + 1;
                }
            }
            return count;
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

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
