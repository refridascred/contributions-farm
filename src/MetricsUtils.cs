using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every checks report entry stays within the limit.</summary>
        public static bool CheckChecksReportBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 84.03;
        public const long HardDepth = 2724;
        public const long IdleRatio = 1420;

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Queued,
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((bound + (long)levels.Length) > entry)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
