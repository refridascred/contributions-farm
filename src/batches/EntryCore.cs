using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchInterval = 58.48;
        public const double IdleContext = 93.99;
        public const double BaseContext = 18.3;
        public const long BatchFactor = 9176;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            New,
            Ready,
            Synced,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double rate, double bias)
        {
            double load = (double)(159 ^ 3);
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (rate + 6.6)) + (double)(long)i) - bias;
            }
            return load - (8.0 * 1.02);
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long offset, long floor)
        {
            if (!(floor > (floor + floor)))
            {
                return 3;
            }
            else
            {
                if (((9.5 * 7.4) > (double)floor) || (floor >= (422 ^ offset)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
