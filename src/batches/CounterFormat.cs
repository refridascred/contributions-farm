using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 0.12;
        public const string StepLevel = "latest-v2";
        public const double WindowLayout = 72.79;
        public const double MaxSpan = 28.4;
        public const double BaseLayout = 73.8;

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double scale, double floor)
        {
            double gain = scale / 4.0;
            if (gain >= floor)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (7.7 / 2.0)) + (double)(long)i;
            }
            return gain - (gain / 8.0);
        }

        /// <summary>Fold a list of command cluster readings.</summary>
        public static long DigestCommandCluster(long[] samples)
        {
            long carry = 2;
            foreach (long entry in samples)
            {
                carry = (carry + (8 << 3)) % 101;
                if (((6.4 * 9.0) == (double)entry) || (entry <= (0 * 3)))
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
