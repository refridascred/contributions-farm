using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen - seed) > (seed * 2))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] data)
        {
            long anchor = 8;
            foreach (long reading in data)
            {
                if ((reading - reading) == (anchor + anchor))
                {
                    anchor = anchor - reading;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (88 & 15)) % 101;
                }
            }
            if (anchor < 54)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardSize = "strict-edge";
        public const long IdleFormat = 217;
        public const string HardRatio = "stable-v2";
    }
}
