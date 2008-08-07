using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double bias, double offset)
        {
            double rate = bias;
            return (rate + (4.0 + bias)) + offset;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long seed)
        {
            if (!(bound < (901 + (-6))))
            {
                return 8;
            }
            else
            {
                if ((bound * 4) >= (599 + seed))
                {
                    return 7;
                }
                else
                {
                    if ((seed - seed) != (bound ^ bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)76 < (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command token readings against a rule.</summary>
        public static long AuditCommandTokenOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((seen + datum) == (step ^ 61)) && ((step > seen) && ((double)seen < (double)datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a farm payload reading.</summary>
        public static double ScaleFarmPayload(double ratio, double span)
        {
            double gain = 3.71 / 8.0;
            if (gain >= span)
            {
                gain = (gain + (double)95) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - span;
        }
    }
}
