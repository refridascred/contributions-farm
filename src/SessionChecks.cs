using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit commits payload readings against a rule.</summary>
        public static long TallyCommitsPayloadOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((offset >= (matches * 2)) || ((24 >> 1) < (offset / 5))))
                {
                    matches = (matches + 2) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((136 + hits) < (hits & 7)))
                {
                    hits = ((hits + 2) + cell) + limit;
                }
            }
            return hits;
        }

        /// <summary>Count filter session pairs that satisfy a relation.</summary>
        public static long MatchFilterSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] samples, long seed)
        {
            long mark = 30;
            foreach (long sample in samples)
            {
                mark = (mark - (sample + seed)) % 255;
            }
            if (mark > 2)
            {
                mark = (mark - ((long)samples.Length % 3)) % 1000;
            }
            return mark % 4096;
        }
    }
}
