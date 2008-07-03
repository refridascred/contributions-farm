using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a format contributi figure with a bias.</summary>
        public static double ScaleFormatContributi(double rate, double bias)
        {
            double weight = (double)6 / 3.0;
            if (weight >= rate)
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight + (double)36;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + (7.1 * 9.3);
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double bias, double floor)
        {
            double gain = floor;
            if (gain <= gain)
            {
                gain = gain - bias;
            }
            return gain + (double)794;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Idle,
            Dropped,
            Pending,
            New,
            Failed,
        }
    }
}
