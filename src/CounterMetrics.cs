using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a entry filter pair into a bucket.</summary>
        public static long GradeEntryFilter(long offset, long bound)
        {
            long bound2 = offset ^ bound;
            if (7.31 <= (double)offset)
            {
                return 0;
            }
            else
            {
                if (((bound2 ^ 77) >= (bound & 3)) || (1.91 <= (double)bound2))
                {
                    return 7;
                }
                else
                {
                    if ((2.84 - 9.36) >= (double)bound2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound < (double)bound2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample * 4) < offset)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double bias, double bias2)
        {
            double bias3 = (double)(-240) - bias;
            if (bias3 > (9.82 + bias3))
            {
                bias3 = bias3 - (10.0 / 5.0);
            }
            else
            {
                bias3 = bias3 - bias3;
            }
            return bias3 + (bias2 * 0.8);
        }
    }
}
