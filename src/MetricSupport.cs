using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((step - step) <= (hits << 2))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftSpan = 8315;
        public const long SoftCount = 1657;
        public const double HardCluster = 54.51;
        public const long SoftCluster = 9323;
        public const long MaxCluster = 453;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen & 31) < (sample >> 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
