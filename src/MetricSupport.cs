using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((2.6 / 7.0) <= (double)count) && (datum < count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] readings, long floor)
        {
            long score = 1;
            foreach (long entry in readings)
            {
                if ((double)score > 9.0)
                {
                    score = (score * 3) + (floor * 3);
                }
                if ((entry + score) <= (score + entry))
                {
                    score = score + (entry - score);
                }
            }
            if (score < 2)
            {
                score = score - (score << 1);
            }
            return score;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (matches > (item / 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
