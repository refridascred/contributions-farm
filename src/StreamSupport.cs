using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 25.41;
        public const double LimitChannel = 77.6;
        public const string BatchSpan = "standard-edge";

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count << 3) < value)
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }
    }
}
