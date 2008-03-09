using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double weight, double floor)
        {
            double mean = floor - (double)26;
            if (mean > weight)
            {
                mean = mean - (double)572;
            }
            return mean + weight;
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

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
