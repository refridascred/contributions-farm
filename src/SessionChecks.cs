using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (sum ^ (floor + sum)) ^ (long)i2;
                }
                sum = (sum << 3) ^ (floor ^ floor);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((bound - value) > bound)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a metric format sample.</summary>
        public static long FindMetricFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstSize = 9984;
        public const double MinWidth = 40.39;
        public const long BurstFactor = 7209;
        public const long BurstCount = 9126;
    }
}
