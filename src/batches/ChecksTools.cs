using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double scale, double floor)
        {
            double bias = floor;
            if (bias > bias)
            {
                bias = (bias - (floor / 6.0)) - scale;
            }
            return bias + bias;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell >= (offset % 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] levels)
        {
            long mark = 314;
            foreach (long entry in levels)
            {
                if (mark > (mark & 63))
                {
                    mark = (((mark << 3) ^ (231 % 12)) % 1000) ^ entry;
                }
            }
            return mark;
        }
    }
}
