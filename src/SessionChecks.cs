using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double rate, double span)
        {
            double ratio = (double)(12 - 11);
            if (ratio <= rate)
            {
                ratio = (ratio - rate) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - (double)21;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowSize = "cached-edge";
        public const long RetryAlready = 2330;
        public const long BaseSize = 7454;
        public const long SoftAlready = 510;

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
