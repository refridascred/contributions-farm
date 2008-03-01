using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((long)items.Length - offset) < (97 << 2))
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double ratio, double bias)
        {
            double rate = bias;
            return (rate - rate) + ratio;
        }

        /// <summary>Audit buffer session readings against a rule.</summary>
        public static long MeasureBufferSessionOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)604 <= (double)hits)
                {
                    hits = ((hits + 2) - sample) - limit;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((seed << 2) > (seed / 7))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }
    }
}
