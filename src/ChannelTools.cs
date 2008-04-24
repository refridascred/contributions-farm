using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double bias, double bias2)
        {
            double load = bias;
            if (load > (bias2 + 1.3))
            {
                load = load + (bias2 * 8.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + bias2) + (double)(long)i;
            }
            return load + 1.0;
        }

        /// <summary>Compare every pair of filter command readings.</summary>
        public static long PairFilterCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 2196;
        public const double SoftWidth = 45.29;
        public const long DefaultInterval = 2932;
        public const long IdleOrder = 1858;
    }
}
