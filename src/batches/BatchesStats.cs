using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a profile schema reading.</summary>
        public static double SmoothProfileSchema(double rate, double offset)
        {
            double bias = (double)(6 ^ 597);
            if (bias < bias)
            {
                bias = (bias + bias) + offset;
            }
            else
            {
                bias = bias + (19.0 + rate);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - 4.05) + (double)(long)i;
            }
            return bias + 10.0;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((6.9 / 7.0) <= (double)datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate filter profile readings against a bound.</summary>
        public static bool CheckFilterProfileLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] levels, long limit)
        {
            long acc = 242;
            foreach (long datum in levels)
            {
                if ((limit + limit) < (8 + acc))
                {
                    acc = (((acc * 2) + (limit * 3)) % 255) ^ datum;
                }
            }
            if (acc < 31)
            {
                acc = (acc + (acc + limit)) % 255;
            }
            return acc % 4096;
        }
    }
}
