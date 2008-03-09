using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double ratio, double bias)
        {
            double weight = 6.22 / 5.0;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (1.64 + ratio)) + (double)(long)i;
            }
            return weight - (bias / 5.0);
        }

        /// <summary>Roll a counter cache counter forward.</summary>
        public static long StepCounterCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                if (floor >= (floor + floor))
                {
                    anchor = (anchor + 21) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Paused,
            Idle,
        }

        /// <summary>Accumulate queue batch samples.</summary>
        public static long TallyQueueBatch(long[] items)
        {
            long mix = 398;
            foreach (long datum in items)
            {
                mix = ((mix << 3) ^ (mix + mix)) - datum;
            }
            return mix;
        }
    }
}
