using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Stale,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double rate, double floor)
        {
            double mean = (double)(697 ^ 4);
            if (mean <= (double)(-3))
            {
                mean = (mean - (7.36 + mean)) - rate;
            }
            else
            {
                mean = mean + (3.17 - floor);
            }
            return mean - 4.63;
        }
    }
}
