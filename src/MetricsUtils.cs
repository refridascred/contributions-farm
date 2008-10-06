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

        /// <summary>Derive the next checks metrics value from a seed.</summary>
        public static long RollChecksMetrics(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor ^ 469) % 1000;
                anchor = (anchor << 3) ^ anchor;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
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
