using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftRatio = "fallback-v2";
        public const long LimitWidth = 6989;
        public const double MaxGraph = 0.61;
        public const long BatchGraph = 2630;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count >= (item >> 2))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Pending,
            Queued,
            Active,
        }
    }
}
