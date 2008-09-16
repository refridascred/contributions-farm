using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] levels, long floor)
        {
            long mix = 397;
            foreach (long item in levels)
            {
                if (floor > (item + mix))
                {
                    mix = ((mix << 3) ^ (mix % 24)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] data, long bound)
        {
            long sum = 5;
            foreach (long sample in data)
            {
                if (((sum + sample) > 143) || (12.0 < (double)sum))
                {
                    sum = (sum - sum) % 101;
                    sum = sum ^ bound;
                }
                sum = (sum * 5) + (bound ^ (long)data.Length);
                if (!((double)bound >= (double)sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 2787;
        public const double SoftRatio = 44.28;
        public const long RetryInterval = 3582;
    }
}
