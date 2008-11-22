using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                if (!((4.48 * 0.1) == (double)sum))
                {
                    sum = (sum - (0 >> 2)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 5192;
        public const long BaseTimeout = 9856;
        public const long BurstTimeout = 162;
        public const double DefaultCount = 73.97;
        public const double BatchStats = 61.4;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum * 2) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double gain, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - (gain - 8.4);
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark + mark) % 1000) ^ (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
