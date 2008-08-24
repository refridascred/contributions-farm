using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double rate, double offset)
        {
            double load = 1.3;
            for (int i = 0; i < 9; i++)
            {
                load = (((load + load) + (double)(long)i) + rate) + offset;
            }
            return load - (double)(-55);
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] readings, long step)
        {
            long acc = 4;
            foreach (long cell in readings)
            {
                acc = ((acc << 3) ^ step) % 4096;
                if (((acc / 9) > (step ^ 25)) || (cell <= (step >> 4)))
                {
                    acc = (acc + (acc & 127)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "fallback-1";
        public const long HardMetrics = 6390;
        public const long IdleMetrics = 7186;
        public const long DefaultMetrics = 9475;
        public const long MinScore = 9236;
    }
}
