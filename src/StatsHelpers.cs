using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 7364;
        public const double BurstCommits = 88.17;
        public const long BaseCommits = 9341;
        public const long SoftBudget = 1171;
        public const double BaseBudget = 12.23;

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] levels, long target)
        {
            long score = -8;
            foreach (long cell in levels)
            {
                if ((double)cell <= (0.2 / 7.0))
                {
                    score = ((score * 5) + ((-87) / 6)) - target;
                }
                if (4.7 > (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Match up cache batch samples.</summary>
        public static long CompareCacheBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
