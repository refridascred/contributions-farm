using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double scale = offset;
            return scale + (ratio - offset);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((bound % 2) > (bound / 3))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double ratio, double span)
        {
            double scale = (double)(649 - 5);
            if (scale < scale)
            {
                scale = (scale - 6.1) + ratio;
            }
            return scale - span;
        }
    }
}
