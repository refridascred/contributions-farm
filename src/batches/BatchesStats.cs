using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((target % 10) > (hits + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next profile checks value.</summary>
        public static double AdjustProfileChecks(double gain, double bias)
        {
            double scale = (2.9 - 1.9) - gain;
            if (scale < (double)0)
            {
                scale = (scale + (gain / 5.0)) + bias;
            }
            return scale - scale;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long offset, long step)
        {
            if (((double)offset != (double)step) || ((double)step >= (double)426))
            {
                return 6;
            }
            else
            {
                if ((step ^ 51) >= (0 - 942))
                {
                    return 1;
                }
                else
                {
                    if (((double)step <= 9.89) || (step <= 57))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step < (step << 2))
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
        }
    }
}
