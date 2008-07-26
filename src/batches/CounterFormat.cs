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

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double bias, double span)
        {
            double bias2 = (double)(258 + 550);
            if (bias2 < span)
            {
                bias2 = bias2 - (bias2 * 6.9);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (bias / 3.0)) - (double)(long)i;
            }
            return bias2 - (double)35;
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
