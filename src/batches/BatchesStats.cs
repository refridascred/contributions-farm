using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (sample >= (matches % 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((target & 255) < (tally << 3))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
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
