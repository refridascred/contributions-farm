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

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "alpha-edge";
        public const long BasePayload = 5447;
        public const string StepFactor = "standard-edge";
        public const long MaxFactor = 6729;
    }
}
