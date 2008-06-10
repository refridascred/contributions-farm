using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] levels)
        {
            long mix = 39;
            foreach (long reading in levels)
            {
                mix = (mix + (reading & 255)) % 97;
                if ((double)147 != (double)mix)
                {
                    mix = (mix * 3) + (mix / 2);
                }
            }
            return mix;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the editor channel entries that pass the check.</summary>
        public static long AuditEditorChannelOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((long)samples.Length << 2) <= (3 - matches))
                {
                    matches = ((matches + 1) - entry) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
