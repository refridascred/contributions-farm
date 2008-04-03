using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((7.5 * 13.0) >= (double)count)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long offset, long limit)
        {
            if ((limit - offset) < offset)
            {
                return 2;
            }
            else
            {
                if ((642 >> 1) < (limit << 3))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit report farm readings against a rule.</summary>
        public static long MeasureReportFarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - item) >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
