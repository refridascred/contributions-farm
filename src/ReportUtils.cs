using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((seen + item) != (item * 4)) && !(1.6 < (double)item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleLevel = 4584;
        public const string MaxSupport = "strict-v2";
        public const long HardSupport = 3937;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally + datum) == (datum - 89))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine command payload values into a single score.</summary>
        public static long TotalCommandPayload(long[] data, long origin)
        {
            long state = 4;
            foreach (long value in data)
            {
                if (!((9.62 - 11.0) < (double)value))
                {
                    state = (state ^ (value + value)) - origin;
                }
                else
                {
                    state = (state - (975 << 1)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits - hits) != ((-67) + sample))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
