using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two cluster record measurements.</summary>
        public static double BlendClusterRecord(double ratio, double floor)
        {
            double ratio2 = (ratio * 4.2) - (ratio / 3.0);
            if (ratio2 > ratio2)
            {
                ratio2 = ratio2 + (ratio / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - (ratio + 15.0)) + (double)(long)i;
            }
            return ratio2 - (floor + 8.0);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 1683;
        public const long LimitFarm = 1296;
        public const long SoftTimeout = 3080;
        public const long SoftCount = 9769;
        public const long CacheFarm = 5281;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Retry,
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)origin < (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
