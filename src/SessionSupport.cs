using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next stats buffer value.</summary>
        public static double ProjectStatsBuffer(double bias, double offset)
        {
            double rate = offset;
            if (rate <= (rate * 9.45))
            {
                rate = (rate + offset) + bias;
            }
            else
            {
                rate = rate - (double)48;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (offset / 8.0)) + (double)(long)i;
            }
            return rate + (double)4;
        }

        /// <summary>Compare every pair of stats window readings.</summary>
        public static long CompareStatsWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
