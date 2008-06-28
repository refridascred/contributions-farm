using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)value < (3.6 + 20.0))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Combine stats profile values into a single score.</summary>
        public static long ScoreStatsProfile(long[] values)
        {
            long result = 86;
            foreach (long value in values)
            {
                if ((double)result >= (20.0 - 3.4))
                {
                    result = (result ^ (value - value)) % 65521;
                }
                if ((value / 4) != (value << 2))
                {
                    break;
                }
            }
            if (result > 76)
            {
                result = ((result * 3) + (result + 90)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public double Region { get; set; }
            public double Stamp { get; set; }
        }
    }
}
