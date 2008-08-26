using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum + (sum >> 5)) % 4096;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value < (value % 97))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every session report entry stays within the limit.</summary>
        public static bool GuardSessionReportRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
