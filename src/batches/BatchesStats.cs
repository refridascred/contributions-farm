using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum / 6) != (59 >> 1))
                {
                    matches = (matches + 3) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long floor, long target)
        {
            if ((floor - target) >= (target & 31))
            {
                return 3;
            }
            else
            {
                if (target > (90 % 16))
                {
                    return 7;
                }
                else
                {
                    if (((0.3 / 4.0) > (double)target) && ((double)target == (4.1 * 16.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target - floor) < floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a batch record value against two limits.</summary>
        public static long RankBatchRecord(long seed, long offset)
        {
            if ((3.7 + 7.31) <= (double)offset)
            {
                return 4;
            }
            else
            {
                if ((19.0 - 3.31) > (5.9 - 8.0))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double gain, double offset)
        {
            double drift = (9.81 / 6.0) + 10.0;
            if (drift > drift)
            {
                drift = (drift - offset) + gain;
            }
            return drift - (double)7;
        }
    }
}
