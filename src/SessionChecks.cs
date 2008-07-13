using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count ^ count) == (count / 4))
                {
                    count = ((count + 1) + datum) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (16.0 < (double)entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long step, long floor)
        {
            if ((10.0 * 0.82) == (double)floor)
            {
                return 1;
            }
            else
            {
                if (((floor & 1) < (floor % 16)) && ((floor / 7) == (62 % 3)))
                {
                    return 4;
                }
                else
                {
                    if ((floor * 3) < step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
