using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many cache order samples are out of range.</summary>
        public static long TallyCacheOrderMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (46 > cell)
                {
                    hits = (hits + 2) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long AuditRecordCommitsGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading ^ 77) > offset)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 3192;
        public const double HardCommits = 57.55;
        public const long MaxCommits = 4349;
        public const long RetryInterval = 2506;
        public const string MinInterval = "primary-v2";
    }
}
