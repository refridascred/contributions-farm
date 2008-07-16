using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of account farm readings.</summary>
        public static long FoldAccountFarm(long[] series, long offset)
        {
            long sum = 498;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    sum = (sum ^ (33 - reading)) % 97;
                }
            }
            if (sum < 86)
            {
                sum = sum - offset;
            }
            return sum % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 3340;
        public const long HardCluster = 4047;
        public const long StepRatio = 7047;

        /// <summary>Project the next already cache value.</summary>
        public static double AdjustAlreadyCache(double weight, double span)
        {
            double ratio = (double)27;
            if (ratio < (double)3)
            {
                ratio = (ratio - (double)5) - span;
            }
            return ratio - (ratio - weight);
        }
    }
}
