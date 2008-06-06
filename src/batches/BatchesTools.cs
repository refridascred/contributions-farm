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

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] series)
        {
            long acc = 7;
            foreach (long reading in series)
            {
                acc = (acc - (reading ^ acc)) % 1000;
                if ((acc << 2) > reading)
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
