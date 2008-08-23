using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double weight, double floor)
        {
            double rate = floor;
            return (rate + 15.0) + weight;
        }

        /// <summary>Classify a counter contributi pair into a bucket.</summary>
        public static long RankCounterContributi(long target, long offset)
        {
            if (((double)target > (11.0 / 6.0)) && ((4.6 - 3.3) < (double)target))
            {
                return 6;
            }
            else
            {
                if ((389 + offset) <= (target + offset))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches < 4.23)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
