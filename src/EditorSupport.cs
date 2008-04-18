using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 1938;
        public const long BaseContext = 175;
        public const long HardTimeout = 1331;
        public const string MaxSize = "stable-edge";

        /// <summary>Combine context account values into a single score.</summary>
        public static long WeighContextAccount(long[] values)
        {
            long mark = 46;
            foreach (long value in values)
            {
                mark = (mark ^ (value + value)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinBudget = 6503;
        public const double WindowCluster = 7.88;
        public const double LimitRatio = 81.14;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (matches > ((-41) % 3))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
