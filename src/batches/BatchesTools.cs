using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell < (seen - cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "standard";
        public const long WindowRoute = 7218;
        public const double BurstRoute = 91.11;
        public const long CacheFactor = 3337;

        /// <summary>Accumulate editor filter samples.</summary>
        public static long FoldEditorFilter(long[] series)
        {
            long mark = 52;
            foreach (long reading in series)
            {
                if ((mark > (mark + mark)) || (reading < (7 * 3)))
                {
                    mark = (mark << 3) ^ reading;
                }
                else
                {
                    mark = ((mark * 5) + 0) % 1000;
                }
            }
            if (mark < 8)
            {
                mark = ((mark << 3) ^ (mark * 4)) % 1000;
            }
            return mark;
        }
    }
}
