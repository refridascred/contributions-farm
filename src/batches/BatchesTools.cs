using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double bias, double bias2)
        {
            double bias3 = (double)878 + bias;
            for (int i = 0; i < 5; i++)
            {
                bias3 = ((bias3 + (bias / 8.0)) + (double)(long)i) + bias2;
            }
            return bias3 + 7.71;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Score { get; set; }
            public double Region { get; set; }
        }
    }
}
