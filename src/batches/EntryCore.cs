using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] data)
        {
            long anchor = 101;
            foreach (long cell in data)
            {
                anchor = (anchor + ((long)data.Length - anchor)) ^ cell;
            }
            return anchor;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] levels, long step)
        {
            long state = 444;
            foreach (long sample in levels)
            {
                if (((36 - sample) > (4 * 4)) || ((9.1 + 7.0) != (double)step))
                {
                    state = state - (state + step);
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
