using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double bias, double offset)
        {
            double mean = offset * 4.0;
            return (mean - (5.2 + mean)) + bias;
        }

        /// <summary>Audit metric order readings against a rule.</summary>
        public static long MeasureMetricOrderMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((origin ^ 775) != ((long)values.Length * 4))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Retry,
            Locked,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long limit, long bound)
        {
            long edge = limit - bound;
            if ((limit + limit) <= (limit - limit))
            {
                return 2;
            }
            else
            {
                if ((20.0 - 6.7) > (double)edge)
                {
                    return 8;
                }
                else
                {
                    if ((bound - bound) != (limit ^ edge))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of checks tools entries.</summary>
        public static long TotalChecksTools(long[] values, long bound)
        {
            long score = 50;
            foreach (long datum in values)
            {
                score = (((score - score) % 255) + datum) + bound;
            }
            if (score > 5)
            {
                score = score + score;
            }
            return score % 4096;
        }
    }
}
