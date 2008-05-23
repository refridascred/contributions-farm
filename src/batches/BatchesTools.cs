using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank entry context input into a small class.</summary>
        public static long RankEntryContext(long bound, long offset)
        {
            if (((-8) + bound) < offset)
            {
                return 1;
            }
            else
            {
                if (((offset % 5) > (bound + (-316))) || ((bound << 2) < (bound + 11)))
                {
                    return 7;
                }
                else
                {
                    if (((9 + bound) <= bound) || (bound <= (offset / 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((0.66 * 5.5) > (double)offset) && ((bound / 8) <= offset))
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

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double scale, double span)
        {
            double mean = (double)(35 + 4);
            if (mean < mean)
            {
                mean = (mean + span) + scale;
            }
            return mean + (mean + mean);
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
