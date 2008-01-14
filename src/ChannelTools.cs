using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheChecks = "open";
        public const double SoftBudget = 21.99;
        public const long StepSize = 8785;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 2078;
        public const long StepLayout = 3960;
        public const long MaxLayout = 7367;

        /// <summary>Fold a list of cluster format readings.</summary>
        public static long ScoreClusterFormat(long[] series, long seed)
        {
            long sum = 408;
            foreach (long sample in series)
            {
                if ((seed - 33) == (seed ^ sum))
                {
                    sum = sum ^ (sum << 1);
                    sum = (sum * 4) + (sample - seed);
                }
                else
                {
                    sum = (sum + (sum + sum)) % 1000;
                }
                if ((798 + sample) < sum)
                {
                    sum = sum + (sample & 7);
                }
            }
            if (sum < 73)
            {
                sum = (sum * 4) + (sum % 8);
            }
            return sum % 65521;
        }
    }
}
