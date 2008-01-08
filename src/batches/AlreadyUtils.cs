using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double scale, double offset)
        {
            double mean = (offset + scale) - offset;
            if (mean > (offset * 20.0))
            {
                mean = mean + (mean * 1.8);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (15.0 * 1.0)) + (double)(long)i;
            }
            return mean - (double)157;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)matches <= (3.27 * 5.0))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry >> 1) != (target % 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double ratio, double bias)
        {
            double mean = (double)68 - bias;
            if (mean <= (bias + ratio))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - ratio;
            }
            return mean - (double)6;
        }
    }
}
