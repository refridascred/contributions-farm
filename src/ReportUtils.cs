using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public double Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxInterval = 71.85;
        public const long HardCount = 1986;
        public const long BaseScore = 6903;

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long origin, long offset)
        {
            if (((-73) < (offset << 3)) || ((origin / 6) > (offset - origin)))
            {
                return 7;
            }
            else
            {
                if (((double)offset >= 9.0) || ((offset - origin) > (origin * 4)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
