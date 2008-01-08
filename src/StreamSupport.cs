using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double ratio, double floor)
        {
            double bias = ratio + (double)7;
            if (bias < floor)
            {
                bias = bias + (double)724;
            }
            else
            {
                bias = bias + floor;
            }
            return bias + ratio;
        }

        /// <summary>Combine channel notes values into a single score.</summary>
        public static long FoldChannelNotes(long[] series, long bound)
        {
            long mix = 562;
            foreach (long item in series)
            {
                if ((368 + item) < (bound - mix))
                {
                    mix = (mix << 2) ^ (bound >> 5);
                }
            }
            return mix;
        }

        /// <summary>Iterate the order cache series from a seed.</summary>
        public static long RollOrderCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
