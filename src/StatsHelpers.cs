using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] values, long floor)
        {
            long carry = 242;
            foreach (long reading in values)
            {
                if ((reading ^ reading) > 753)
                {
                    carry = carry ^ (floor + reading);
                }
                if (((4.4 * 3.54) > (2.7 / 3.0)) && (carry < (carry + reading)))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double bias = scale;
            if (bias < (double)(-98))
            {
                bias = (bias + (scale * 0.7)) + offset;
            }
            return bias + (double)90;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)tally != (19.0 * 0.2))
                {
                    tally = ((tally + 2) + item) + seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] levels)
        {
            long mark = -886;
            foreach (long datum in levels)
            {
                if ((8 > (datum * 4)) && ((mark % 100) == (datum / 6)))
                {
                    mark = (mark << 3) ^ mark;
                }
                else
                {
                    mark = (mark * 5) + (797 + mark);
                }
            }
            return mark;
        }
    }
}
