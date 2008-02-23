using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((datum - seen) >= (43 & 15)) && (datum > (datum - datum)))
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

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long step, long floor)
        {
            if ((floor + floor) != (35 >> 4))
            {
                return 3;
            }
            else
            {
                if (step <= (step * 3))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a stats context value against two limits.</summary>
        public static long ClassifyStatsContext(long origin, long step)
        {
            long span = origin - step;
            if ((step + span) != (step % 100))
            {
                return 0;
            }
            else
            {
                if (((origin ^ span) != (36 + span)) && (step > (span + 253)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
