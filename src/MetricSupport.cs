using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item / 4) < hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] series)
        {
            long acc = 42;
            foreach (long cell in series)
            {
                if (((cell * 2) >= 5) || ((cell + cell) >= (acc * 4)))
                {
                    acc = (acc * 4) + cell;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "alpha-edge";
        public const long BasePayload = 5447;
        public const string StepFactor = "standard-edge";
        public const long MaxFactor = 6729;
    }
}
