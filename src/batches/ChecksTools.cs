using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two record window measurements.</summary>
        public static double ScaleRecordWindow(double weight, double bias)
        {
            double drift = (double)(9 & 1);
            if (drift < drift)
            {
                drift = drift - (drift * 11.0);
            }
            else
            {
                drift = drift + weight;
            }
            return drift - bias;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepInterval = "staging";
        public const long IdleProfile = 9375;
        public const long WindowProfile = 9172;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples, long offset)
        {
            long sum = 990;
            foreach (long item in samples)
            {
                sum = (((sum << 2) ^ 1) - item) + offset;
            }
            if (sum > 3)
            {
                sum = (sum + (883 + (-820))) % 1000;
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardWidth = 6015;
        public const string WindowMetrics = "open";
        public const double BaseTimeout = 22.86;
        public const long MinSpan = 1711;
    }
}
