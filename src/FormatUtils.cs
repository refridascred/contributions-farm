using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double ratio2 = (double)(23 + 8);
            if (ratio2 >= (5.18 - span))
            {
                ratio2 = (ratio2 - ratio2) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 - (double)(-9);
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long bound, long bound2)
        {
            if ((bound2 * 2) <= (bound - bound))
            {
                return 8;
            }
            else
            {
                if (((bound2 ^ bound2) >= (bound2 << 3)) && (bound2 > (bound2 ^ bound)))
                {
                    return 5;
                }
                else
                {
                    if (((bound2 + bound2) >= bound2) && ((bound - bound2) == (bound + bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] series)
        {
            long state = 0;
            foreach (long cell in series)
            {
                if ((double)state == (7.0 * 11.0))
                {
                    state = ((state + 37) % 1000) + cell;
                }
            }
            return state;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double weight, double offset)
        {
            double rate = (offset * 10.0) / 2.0;
            if (rate <= 5.22)
            {
                rate = rate + (offset + weight);
            }
            else
            {
                rate = rate - offset;
            }
            return rate + offset;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            New,
            Draft,
        }
    }
}
