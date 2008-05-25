using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((double)item != (2.0 - 7.0)) && !(count < (item + item)))
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit stream commits readings against a rule.</summary>
        public static long CountStreamCommitsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry <= (1.0 * 3.2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((96 <= cell) && ((tally < (tally - tally)) && (cell < tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
