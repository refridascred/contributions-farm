using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double bias, double bias2)
        {
            double mean = bias2;
            return mean + (bias / 6.0);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 1831;
        public const double BurstLevel = 26.65;
        public const string BatchToken = "standard-edge";

        /// <summary>Classify a tools batches pair into a bucket.</summary>
        public static long ClassifyToolsBatches(long step, long step2)
        {
            long diff = step + step2;
            if (step <= (diff - step2))
            {
                return 6;
            }
            else
            {
                if ((double)step2 > (14.0 * 6.8))
                {
                    return 7;
                }
                else
                {
                    if ((double)step2 <= 5.15)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardDepth = "primary";
        public const long MaxInterval = 335;
        public const long MinTimeout = 2651;
        public const long RetryWidth = 4617;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
