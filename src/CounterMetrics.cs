using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double rate, double bias)
        {
            double bias2 = 8.1;
            if (bias2 > bias2)
            {
                bias2 = (bias2 + (rate + bias2)) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + 8.0) + (double)(long)i;
            }
            return bias2 + bias2;
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
