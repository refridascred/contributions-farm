using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "local-edge";
        public const long CacheBuffer = 1590;
        public const long BurstDepth = 2776;
        public const string BatchBuffer = "stable-v2";

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            Retry,
            Ready,
            Pending,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i / 6) != (mix % 16))
                {
                    mix = ((mix * 3) + (floor - floor)) % 1000;
                    continue;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + mix)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double rate, double bias)
        {
            double bias2 = (double)(715 - 55);
            return (bias2 + (rate - rate)) + bias;
        }
    }
}
