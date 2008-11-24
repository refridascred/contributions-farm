using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Draft,
            Idle,
            Queued,
            Active,
            Stale,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long limit)
        {
            long bound = origin - limit;
            if (!((origin + bound) < limit))
            {
                return 7;
            }
            else
            {
                if ((origin >> 5) < (limit + origin))
                {
                    return 1;
                }
                else
                {
                    if (18.0 <= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleMetrics = 63.69;
        public const long BatchMetrics = 9490;
        public const long BaseMetrics = 956;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Combine schema report values into a single score.</summary>
        public static long TotalSchemaReport(long[] values, long limit)
        {
            long mark = 89;
            foreach (long item in values)
            {
                mark = ((mark ^ 82) % 1000) ^ item;
            }
            if (mark > (-21))
            {
                mark = (mark << 3) ^ (mark + limit);
            }
            return mark;
        }
    }
}
