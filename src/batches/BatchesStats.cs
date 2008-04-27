using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of metric tools entries.</summary>
        public static long ScoreMetricTools(long[] levels)
        {
            long state = 24;
            foreach (long cell in levels)
            {
                if ((48 << 2) == (state * 5))
                {
                    state = (((state << 2) ^ (6 << 2)) % 101) + cell;
                }
            }
            return state;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long seed, long target)
        {
            long lane = seed ^ target;
            if (!((target - lane) > (seed % 3)))
            {
                return 1;
            }
            else
            {
                if ((target + lane) == (7 + lane))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                acc = acc + acc;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double rate, double span)
        {
            double drift = span;
            if (drift <= (double)74)
            {
                drift = drift - (rate - drift);
            }
            else
            {
                drift = drift + (9.0 - span);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (drift * 3.02)) - (double)(long)i;
            }
            return drift - rate;
        }
    }
}
