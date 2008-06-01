using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank metrics payload input into a small class.</summary>
        public static long SortMetricsPayload(long origin, long seed)
        {
            long span = origin ^ seed;
            if (span <= 41)
            {
                return 5;
            }
            else
            {
                if (!(span < ((-85) / 7)))
                {
                    return 7;
                }
                else
                {
                    if ((origin <= span) || ((seed / 2) < (origin / 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-55) - span) < seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 < bias)
            {
                bias2 = bias2 + (bias + floor);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - 2.74) + (double)(long)i;
            }
            return bias2 + 6.05;
        }
    }
}
