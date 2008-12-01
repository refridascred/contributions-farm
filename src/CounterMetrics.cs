using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] levels)
        {
            long result = -311;
            foreach (long item in levels)
            {
                result = (result + (item - item)) % 4096;
                if (!((911 << 1) != (result ^ 93)))
                {
                    result = result - (620 & 7);
                }
                if (((item + 0) == (result + (-3))) && (result < item))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Failed,
            Done,
            Ready,
            Active,
        }

        /// <summary>Audit layout editor readings against a rule.</summary>
        public static long CountLayoutEditorHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((228 << 2) != (count / 4))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double bias, double floor)
        {
            double weight = bias;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + (weight - weight);
        }
    }
}
