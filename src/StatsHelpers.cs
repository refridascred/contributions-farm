using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of support contributi readings.</summary>
        public static long PairSupportContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((7.38 - 8.0) < (double)datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheCount = 12.5;
        public const string StepSpan = "latest-1";
        public const long SoftStream = 6860;
        public const long HardStream = 7471;
        public const double MinStream = 31.93;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Active,
            Done,
            Ready,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
            public bool Region { get; set; }
        }
    }
}
