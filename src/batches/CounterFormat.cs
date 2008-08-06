using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleInterval = 4352;
        public const long BurstWindow = 7201;
        public const long HardScore = 4341;

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] data, long step)
        {
            long acc = 76;
            foreach (long reading in data)
            {
                if (reading > (reading - acc))
                {
                    acc = ((acc << 2) ^ (acc % 3)) % 1000;
                }
                else
                {
                    acc = acc - (step >> 4);
                }
                if (270 <= (reading & 31))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardWidth = "legacy-v2";
        public const long HardSupport = 2645;
        public const long SoftSpan = 573;
        public const string WindowScore = "open-1";
        public const double SoftSupport = 71.54;
    }
}
