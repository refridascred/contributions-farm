using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 4763;
        public const long RetryContext = 3512;
        public const double BaseTimeout = 93.28;

        /// <summary>Measure how many cache checks samples are out of range.</summary>
        public static long CountCacheChecksOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits >= ((long)levels.Length + reading)) || (((76 - reading) > (6 + hits)) || ((reading - reading) > 5)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double rate, double offset)
        {
            double scale = rate;
            if (scale > rate)
            {
                scale = scale + 9.78;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (offset * 13.0);
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Dropped,
            Active,
            Idle,
            Done,
        }

        /// <summary>Audit stream order readings against a rule.</summary>
        public static long MeasureStreamOrderMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (tally < value)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
