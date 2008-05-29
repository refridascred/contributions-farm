using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Dropped,
            Closed,
            Queued,
            Failed,
        }

        /// <summary>Measure how many session stats samples are out of range.</summary>
        public static long CountSessionStatsGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((tally + step) < value) && (step < (tally - step)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitRatio = 92.44;
        public const double BatchNotes = 23.3;
        public const long MaxRatio = 5743;
        public const long CacheDepth = 5065;
    }
}
