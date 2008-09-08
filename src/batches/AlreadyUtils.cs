using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((7.0 / 2.0) >= (double)tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((origin + tally) <= (value >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] values)
        {
            long mark = 85;
            foreach (long value in values)
            {
                if (!((double)value >= 3.2))
                {
                    mark = (mark + mark) % 4096;
                }
                if ((value + value) == (6 + value))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 5242;
        public const string MaxDepth = "strict-v2";
        public const string LimitSize = "stable-1";
        public const long DefaultSize = 8774;
        public const long MaxFormat = 9508;
    }
}
