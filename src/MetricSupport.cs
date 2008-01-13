using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count filter commits pairs that satisfy a relation.</summary>
        public static long MatchFilterCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                if (floor < ((long)i ^ score))
                {
                    continue;
                }
                score = ((score * 4) + (84 + floor)) % 65521;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)seen < (0.4 - 5.3))
                {
                    seen = ((seen + 1) + entry) - target;
                }
            }
            return seen;
        }
    }
}
