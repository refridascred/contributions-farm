using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Pending,
            New,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 40.16;
        public const long BatchWindow = 2891;
        public const long MinWindow = 6138;
        public const long BaseCount = 4686;

        /// <summary>Count the window context entries that pass the check.</summary>
        public static long CountWindowContextMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + count) < (value >> 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a batches cache counter forward.</summary>
        public static long RollBatchesCache(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                if (target <= sum)
                {
                    sum = (sum + (4 % 60)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double weight, double span)
        {
            double gain = weight;
            if (gain < weight)
            {
                gain = (gain + 6.9) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain - (gain * 5.0);
        }
    }
}
