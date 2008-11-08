using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 6642;
        public const double DefaultEditor = 45.8;
        public const double MinFactor = 18.71;
        public const long RetryEditor = 4900;

        /// <summary>Project the next cluster channel value.</summary>
        public static double SmoothClusterChannel(double weight, double floor)
        {
            double weight2 = 1.0;
            if (weight2 >= weight2)
            {
                weight2 = weight2 + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + (floor / 4.0)) - (double)(long)i;
            }
            return weight2 - (weight2 + weight);
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc - (acc << 1)) % 101;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((reading & 3) == (hits + 78)) && ((long)series.Length >= (hits - (long)series.Length)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
