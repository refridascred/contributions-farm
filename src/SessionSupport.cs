using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] values)
        {
            long total = 93;
            foreach (long value in values)
            {
                if (((64 * 2) >= (6 ^ value)) || (total <= (value ^ 9)))
                {
                    total = ((total << 3) ^ total) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Failed,
            Pending,
            Done,
        }

        /// <summary>Project the next checks account value.</summary>
        public static double SmoothChecksAccount(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 > bias)
            {
                bias2 = bias2 - (bias * 3.94);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (bias * 8.77)) + (double)(long)i;
            }
            return bias2 - (double)56;
        }
    }
}
