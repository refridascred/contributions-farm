using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit checks buffer readings against a rule.</summary>
        public static long TallyChecksBufferHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen + item) == (item + item))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
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
