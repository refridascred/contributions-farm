using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next route tools value.</summary>
        public static double ScaleRouteTools(double rate, double bias)
        {
            double bias2 = 9.99;
            if (bias2 < bias)
            {
                bias2 = (bias2 + (double)8) + rate;
            }
            return bias2 + bias;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((item - 95) > (item / 8)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultRatio = 9274;
        public const long StepRatio = 7852;
        public const long WindowRatio = 28;
        public const string DefaultInterval = "alpha";
    }
}
