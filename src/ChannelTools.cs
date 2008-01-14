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

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Label { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
        }

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
