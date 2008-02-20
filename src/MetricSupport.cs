using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a already contributi figure with a bias.</summary>
        public static double ScaleAlreadyContributi(double gain, double bias)
        {
            double scale = gain;
            if (scale <= (scale * 6.0))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - (scale - 8.9);
            }
            return scale - 2.2;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 1140;
        public const double DefaultCounter = 42.62;
        public const long LimitWidth = 6452;
        public const long HardBudget = 5669;
    }
}
