using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowFactor = "alpha-1";
        public const string DefaultLevel = "strict-edge";
        public const string RetryScore = "legacy-v2";
        public const string BatchFactor = "fallback-edge";

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheTimeout = 710;
        public const long StepFilter = 4217;
        public const double StepTimeout = 66.87;
        public const long BaseBudget = 2548;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Pending,
            Ready,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] readings)
        {
            long mix = 8;
            foreach (long value in readings)
            {
                mix = mix ^ (91 + value);
                if (((value - value) != (value + value)) && (value >= (460 * 2)))
                {
                    mix = (mix ^ (value + value)) % 101;
                }
            }
            return mix % 4096;
        }
    }
}
