using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Failed,
            New,
            Active,
            Paused,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitTimeout = 25.33;
        public const long StepScore = 2795;
        public const double LimitEntry = 46.14;
        public const long SoftTimeout = 8297;
        public const long StepEntry = 8660;

        /// <summary>Classify a stats notes pair into a bucket.</summary>
        public static long RankStatsNotes(long origin, long origin2)
        {
            if (((origin % 64) >= (origin2 << 3)) || ((origin2 + origin2) > (origin2 - origin)))
            {
                return 0;
            }
            else
            {
                if (((double)origin == (2.72 / 7.0)) && ((origin2 - origin2) <= (origin2 + 2)))
                {
                    return 5;
                }
                else
                {
                    if (6 > (origin2 / 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
