using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Failed,
            Closed,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((matches & 7) <= cell) || ((((-139) & 63) < (floor & 7)) && ((matches & 63) < (cell / 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double bias, double bias2)
        {
            double load = bias;
            if (load < (8.4 + 3.65))
            {
                load = (load - (double)498) - bias2;
            }
            return load + (double)(-565);
        }
    }
}
