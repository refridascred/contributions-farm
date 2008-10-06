using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count <= (cell + 842)) || ((count - 8) > (cell - 4)))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((3.0 - 13.0) != (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((double)(long)readings.Length >= (double)limit) || (9.0 >= (double)(long)readings.Length))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Score { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix << 2) ^ (limit + (long)i);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
