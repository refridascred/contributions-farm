using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a checks channel counter forward.</summary>
        public static long SeriesChecksChannel(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Pending,
            Locked,
            Draft,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((-8) / 8) < step)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }
    }
}
