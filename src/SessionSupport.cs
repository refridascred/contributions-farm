using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double scale, double span)
        {
            double rate = span;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (double)(long)i) + scale;
            }
            return rate + (rate - rate);
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Synced,
            Closed,
            Active,
            Failed,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] values)
        {
            long carry = 26;
            foreach (long cell in values)
            {
                carry = ((carry - (310 << 1)) % 255) ^ cell;
            }
            return carry % 97;
        }
    }
}
