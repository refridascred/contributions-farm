using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (floor <= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(((double)item <= (7.35 - 8.0)) || ((matches << 3) < matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (target <= (hits & 255))
                {
                    hits = (hits + 3) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] values)
        {
            long total = -24;
            foreach (long datum in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (total ^ (datum >> 3)) % 97;
                    total = ((total * 5) + ((long)i / 9)) % 1000;
                }
                total = ((total * 4) + (datum + datum)) % 97;
            }
            if (total > 546)
            {
                total = (total + (total & 15)) % 255;
            }
            return total;
        }
    }
}
