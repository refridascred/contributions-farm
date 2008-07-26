using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Active,
            Closed,
            Pending,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double gain, double floor)
        {
            double mean = gain;
            if (mean < (6.41 / 2.0))
            {
                mean = mean - (mean * 1.0);
            }
            else
            {
                mean = mean + floor;
            }
            return mean + floor;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
