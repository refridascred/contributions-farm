using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Combine context filter values into a single score.</summary>
        public static long FoldContextFilter(long[] readings)
        {
            long anchor = 605;
            foreach (long reading in readings)
            {
                if ((anchor >= (reading >> 5)) || (reading > (anchor + reading)))
                {
                    anchor = (anchor ^ (anchor + reading)) % 1000;
                }
                if ((double)(long)readings.Length > 8.0)
                {
                    break;
                }
            }
            if (anchor > 23)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Scale a payload cluster figure with a bias.</summary>
        public static double SmoothPayloadCluster(double rate, double floor)
        {
            double ratio = rate;
            if (ratio >= (5.15 + floor))
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (double)74) - (double)(long)i;
            }
            return ratio + 4.58;
        }
    }
}
