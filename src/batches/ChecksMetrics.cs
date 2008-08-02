using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum * 5) + (sum / 9);
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double gain, double span)
        {
            double bias = span;
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (gain * 11.0)) + (double)(long)i;
            }
            return bias + (span - span);
        }

        /// <summary>Grade a queue profile value against two limits.</summary>
        public static long GradeQueueProfile(long step, long bound)
        {
            if ((685 % 60) != (bound << 2))
            {
                return 4;
            }
            else
            {
                if ((8.7 <= (double)step) || ((bound + bound) > (bound * 3)))
                {
                    return 5;
                }
                else
                {
                    if (((step - step) < (bound - step)) && ((double)bound >= (7.96 * 2.69)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound >= (7.8 * 5.82))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Locked,
            Paused,
            New,
            Retry,
            Active,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (671 <= (origin + 208))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((double)datum == (5.13 * 4.12)) && !((31 - 420) == (matches + datum)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
