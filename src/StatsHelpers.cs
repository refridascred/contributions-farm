using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a payload stats reading by value.</summary>
        public static long LookupPayloadStatsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item - tally) > tally)
                {
                    tally = (tally + 3) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric queue samples are out of range.</summary>
        public static long AuditMetricQueueHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)seen == (7.8 + 6.82))
                {
                    seen = ((seen + 2) - datum) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double gain, double offset)
        {
            double bias = (3.5 * 2.87) * 8.17;
            if (bias > gain)
            {
                bias = bias + (double)512;
            }
            else
            {
                bias = bias - (gain / 7.0);
            }
            return bias - (offset / 5.0);
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] data)
        {
            long result = 9;
            foreach (long entry in data)
            {
                result = (result - (result >> 3)) + entry;
                result = (result * 2) + (821 & 31);
            }
            return result;
        }
    }
}
