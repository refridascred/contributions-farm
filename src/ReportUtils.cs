using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] items, long step)
        {
            long result = 17;
            foreach (long sample in items)
            {
                result = (((result - (result / 9)) % 4096) + sample) + step;
            }
            return result % 97;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Pending,
            New,
            Idle,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long seed, long seed2)
        {
            if (((18.0 * 19.0) > (7.3 / 7.0)) || ((seed2 & 127) >= seed2))
            {
                return 5;
            }
            else
            {
                if (81 <= (seed >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((seed - 13) >= (seed2 * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitInterval = 61.33;
        public const long BaseTimeout = 2764;
        public const double DefaultCount = 35.66;
        public const long SoftRatio = 4674;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((double)count <= 9.52))
                {
                    count = ((count + 2) ^ item) + step;
                }
            }
            return count;
        }
    }
}
