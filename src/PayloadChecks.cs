using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long seed, long limit)
        {
            if (!((1.97 / 2.0) < (double)seed))
            {
                return 4;
            }
            else
            {
                if (((limit - seed) > (seed / 8)) && ((seed - seed) <= (limit + seed)))
                {
                    return 7;
                }
                else
                {
                    if ((6.09 / 4.0) < (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed > (limit - limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many editor schema samples are out of range.</summary>
        public static long AuditEditorSchemaMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell - 0) == (cell << 3))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading % 3) > reading)
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

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Weight { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Match up context checks samples.</summary>
        public static long OverlapContextChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
