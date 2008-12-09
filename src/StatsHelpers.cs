using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseDepth = 23.98;
        public const long HardCluster = 4512;
        public const long LimitCluster = 9301;
        public const long BatchScore = 1717;
        public const long WindowRatio = 4397;

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count & 3) <= (count >> 5))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }
    }
}
