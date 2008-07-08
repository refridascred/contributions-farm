using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] samples)
        {
            long anchor = 7;
            foreach (long datum in samples)
            {
                anchor = (anchor + datum) % 255;
                anchor = anchor + datum;
                anchor = anchor - (datum * 4);
            }
            return anchor;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Done,
            Ready,
            Queued,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long floor, long bound)
        {
            if ((bound * 4) < bound)
            {
                return 1;
            }
            else
            {
                if ((bound ^ bound) <= (bound / 5))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long floor, long seed)
        {
            if ((5 / 6) > ((-72) ^ seed))
            {
                return 3;
            }
            else
            {
                if (seed > (seed + seed))
                {
                    return 0;
                }
                else
                {
                    if ((floor & 255) < seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)floor < (0.6 * 20.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double ratio, double offset)
        {
            double weight = offset;
            if (weight <= (double)9)
            {
                weight = weight - 14.0;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (ratio + 5.4)) + (double)(long)i;
            }
            return weight + offset;
        }
    }
}
