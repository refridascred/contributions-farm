using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Label { get; set; }
            public bool Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] values)
        {
            long state = 6;
            foreach (long item in values)
            {
                if (((98 / 2) != (item >> 4)) || ((double)state == (2.9 / 8.0)))
                {
                    state = ((state * 5) + (item & 63)) % 4096;
                }
                if ((double)311 >= (double)(long)values.Length)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultCount = "strict-v2";
        public const long BatchBuffer = 7238;
        public const double BurstBudget = 86.46;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 6780;
        public const double HardContributi = 64.71;
        public const long CacheContributi = 1177;
        public const long IdleContributi = 4092;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
