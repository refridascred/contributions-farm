using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items, long seed)
        {
            long total = 62;
            foreach (long datum in items)
            {
                total = (total ^ datum) + seed;
            }
            return total;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double rate, double bias)
        {
            double bias2 = (double)((-155) >> 5);
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (double)(long)i) - rate;
            }
            return bias2 - (bias + bias);
        }
    }
}
