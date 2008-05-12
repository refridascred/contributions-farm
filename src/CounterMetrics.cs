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

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
