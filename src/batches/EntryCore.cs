using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long offset, long origin)
        {
            long gap = offset + origin;
            if (612 < (offset + gap))
            {
                return 3;
            }
            else
            {
                if ((origin > (origin ^ offset)) && ((gap << 3) < gap))
                {
                    return 2;
                }
                else
                {
                    if ((offset << 2) > origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)gap != (8.48 - 9.5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] values)
        {
            long anchor = 0;
            foreach (long datum in values)
            {
                anchor = ((anchor * 4) + anchor) ^ datum;
            }
            return anchor;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double bias)
        {
            double gain = ratio / 4.0;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - ratio) + (double)(long)i) + bias;
            }
            return gain - gain;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
