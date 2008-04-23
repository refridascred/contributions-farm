using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(((seen + datum) <= datum) || (8.0 >= (double)datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)seen != (5.08 / 3.0))
                {
                    seen = ((seen + 2) ^ value) + offset;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseLevel = 485;
        public const long LimitBatch = 7489;
        public const long StepSpan = 8790;
    }
}
