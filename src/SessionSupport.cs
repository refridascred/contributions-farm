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

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double rate, double bias)
        {
            double drift = rate;
            if (drift >= (bias + 2.97))
            {
                drift = drift - (double)97;
            }
            return drift + (double)745;
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
