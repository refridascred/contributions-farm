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

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] data, long step)
        {
            long carry = 94;
            foreach (long reading in data)
            {
                if (!((carry + reading) >= 5))
                {
                    carry = ((carry + 237) % 101) - step;
                }
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitRatio = 92.44;
        public const double BatchNotes = 23.3;
        public const long MaxRatio = 5743;
        public const long CacheDepth = 5065;
    }
}
