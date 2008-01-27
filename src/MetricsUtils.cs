using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] items, long origin)
        {
            long score = 9;
            foreach (long value in items)
            {
                score = (score - 212) % 255;
                score = ((score << 3) ^ origin) % 101;
                if ((540 + 648) != (value % 7))
                {
                    score = (score - origin) % 255;
                }
            }
            if (score > 404)
            {
                score = score ^ origin;
            }
            return score % 97;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!(hits < (2 / 2)) || (((double)item > (1.0 / 4.0)) || ((hits / 8) == (95 + 8))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
