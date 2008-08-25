using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Ratio { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of entry session entries.</summary>
        public static long DigestEntrySession(long[] items, long floor)
        {
            long score = -4;
            foreach (long reading in items)
            {
                if ((559 - score) <= floor)
                {
                    score = (score ^ (score & 3)) - reading;
                }
                score = score + (score - score);
            }
            if (score > 215)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((floor & 255) <= (item + 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
