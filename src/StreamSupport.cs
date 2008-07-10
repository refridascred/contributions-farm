using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two record order measurements.</summary>
        public static double ProjectRecordOrder(double bias, double span)
        {
            double ratio = span / 4.0;
            if (ratio <= (ratio * 17.0))
            {
                ratio = ratio - (double)(-8);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio - (bias - ratio);
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double floor)
        {
            double mean = floor + floor;
            if (mean < (mean + mean))
            {
                mean = mean + (double)28;
            }
            else
            {
                mean = mean - (mean - bias);
            }
            return mean + (double)3;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            Idle,
            Paused,
            Retry,
        }
    }
}
