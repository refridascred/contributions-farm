using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a filter batch figure with a bias.</summary>
        public static double ScaleFilterBatch(double bias, double floor)
        {
            double rate = (1.9 / 7.0) - 7.04;
            if (rate > (bias + bias))
            {
                rate = (rate + bias) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (4.78 - bias)) + (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
