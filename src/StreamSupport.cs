using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double scale, double span)
        {
            double ratio = scale;
            return (ratio - (double)63) + span;
        }

        /// <summary>Rank notes counter input into a small class.</summary>
        public static long RankNotesCounter(long bound, long target)
        {
            long cur = bound - target;
            if ((bound >= (bound % 10)) && ((bound + target) < (target * 5)))
            {
                return 6;
            }
            else
            {
                if (!(64 >= (bound % 24)))
                {
                    return 8;
                }
                else
                {
                    if (((cur * 4) <= bound) || ((16.0 / 5.0) >= (double)bound))
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

        /// <summary>Locate a queue account reading by value.</summary>
        public static long LocateQueueAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
