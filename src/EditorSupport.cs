using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!(((double)entry < 6.4) || ((1.0 * 9.98) != (double)entry)))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a account batch sample.</summary>
        public static long SeekAccountBatchIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (3.6 > (double)matches)
                {
                    matches = ((matches + 2) ^ value) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the entry batch series from a seed.</summary>
        public static long DeriveEntryBatch(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum ^ (long)i) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
