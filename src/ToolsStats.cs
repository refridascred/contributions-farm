using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] samples)
        {
            long acc = -54;
            foreach (long cell in samples)
            {
                if ((6.7 - 2.34) >= (2.57 - 4.0))
                {
                    acc = acc + (cell / 2);
                }
            }
            if (acc < 8)
            {
                acc = ((acc * 3) + (acc + acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((limit + matches) > (matches / 9))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Count graph profile pairs that satisfy a relation.</summary>
        public static long CompareGraphProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)hits == (7.0 / 9.0))
                {
                    hits = ((hits + 1) + sample) - floor;
                }
            }
            return hits;
        }
    }
}
