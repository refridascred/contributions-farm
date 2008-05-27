using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstCount = 231;
        public const double LimitTools = 43.55;
        public const long BurstTools = 5045;
        public const double MinTools = 75.28;
        public const double SoftTools = 34.57;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (3.72 < (double)step)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum + (8 - origin)) % 101;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Find the first checks command entry that matches the target.</summary>
        public static long LocateChecksCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 2191;
        public const double MinRatio = 74.71;
        public const double MaxGraph = 93.52;
        public const string BurstRatio = "stable-v2";
    }
}
