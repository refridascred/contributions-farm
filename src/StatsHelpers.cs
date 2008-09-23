using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches <= (entry << 1))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double weight, double floor)
        {
            double rate = 2.74;
            if (rate < rate)
            {
                rate = (rate - weight) - floor;
            }
            else
            {
                rate = rate - (weight / 7.0);
            }
            return rate + (rate - 16.0);
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double weight, double floor)
        {
            double ratio = weight;
            if (ratio <= (ratio * 5.6))
            {
                ratio = (ratio - (0.1 * 8.54)) - floor;
            }
            return ratio + weight;
        }
    }
}
