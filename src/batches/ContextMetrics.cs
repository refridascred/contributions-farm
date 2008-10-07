using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long bound, long bound2)
        {
            if ((bound2 ^ bound) != (6 / 6))
            {
                return 0;
            }
            else
            {
                if (8.8 < (double)bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound ^ bound) < (bound2 + 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long mark = 583;
            foreach (long cell in samples)
            {
                if ((mark + cell) != (mark >> 1))
                {
                    mark = (mark - (61 % 24)) % 1000;
                }
            }
            if (mark > 1)
            {
                mark = ((mark * 4) + mark) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double bias, double span)
        {
            double drift = (double)(11 + 8);
            if (drift > (0.6 + bias))
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (span - drift)) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((5.6 + 9.2) >= (double)sample)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((double)tally > (3.8 / 6.0)) || ((double)reading < (5.5 * 0.89)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
