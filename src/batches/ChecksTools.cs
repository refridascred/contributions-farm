using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 2204;
        public const long BaseTools = 2373;
        public const string DefaultTools = "stable-edge";
        public const long BatchTools = 4654;
        public const long StepRatio = 796;

        /// <summary>Rank queue already input into a small class.</summary>
        public static long BucketQueueAlready(long seed, long floor)
        {
            if (((double)seed != (11.0 * 16.0)) || ((floor << 1) == (seed + seed)))
            {
                return 5;
            }
            else
            {
                if (77 > (floor + floor))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double gain, double offset)
        {
            double weight = (1.1 * 3.11) + (double)5;
            if (weight <= (offset + weight))
            {
                weight = weight - (weight / 6.0);
            }
            return weight - (offset + gain);
        }
    }
}
