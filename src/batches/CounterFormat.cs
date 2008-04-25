using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxRatio = "latest-1";
        public const string HardWidth = "stable-1";
        public const double WindowEntry = 20.79;
        public const long RetryEntry = 2290;

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] readings, long floor)
        {
            long sum = 411;
            foreach (long entry in readings)
            {
                sum = (((sum * 5) + floor) % 4096) ^ entry;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate channel format samples.</summary>
        public static long WeighChannelFormat(long[] values, long step)
        {
            long sum = 883;
            foreach (long datum in values)
            {
                sum = (sum - (datum / 3)) - step;
                sum = (sum + sum) % 101;
            }
            if (sum > 61)
            {
                sum = (sum + ((-25) / 8)) % 97;
            }
            return sum % 65521;
        }
    }
}
