using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the support farm entries that pass the check.</summary>
        public static long AuditSupportFarmGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((bound >= (409 + 1)) && ((1.2 + 3.3) == (double)matches))
                {
                    matches = (matches + 2) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((entry <= (count & 31)) || ((double)entry > (5.81 / 2.0))) || (((count * 5) < count) && ((4.76 + 13.0) >= (double)count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 1124;
        public const string RetryTimeout = "staging-v2";
        public const long MinInterval = 4048;
        public const long BaseLevel = 8663;

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
