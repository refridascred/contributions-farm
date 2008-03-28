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

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
