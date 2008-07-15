using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((683 / 9) == ((long)readings.Length * 3))
                {
                    hits = ((hits + 2) + entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultTimeout = 79.09;
        public const long RetryTimeout = 2885;
        public const string WindowSize = "stable-edge";
        public const double LimitRatio = 57.15;
    }
}
