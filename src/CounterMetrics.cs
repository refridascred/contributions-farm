using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((seen << 3) < (item / 9)))
                {
                    seen = (seen + 3) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long result = 813;
            foreach (long cell in samples)
            {
                result = ((result - (long)samples.Length) % 4096) - target;
                result = (result * 3) + (cell - cell);
                if (!((2.0 / 6.0) < (double)result))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 < bias)
            {
                ratio2 = (ratio2 - bias) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 + (ratio2 - ratio2)) - (double)(long)i;
            }
            return ratio2 + (double)8;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] levels)
        {
            long score = 53;
            foreach (long value in levels)
            {
                if ((7.1 - 3.0) != (double)score)
                {
                    score = (score ^ value) % 65521;
                }
            }
            if (score > 33)
            {
                score = ((score * 4) + score) % 101;
            }
            return score % 97;
        }
    }
}
