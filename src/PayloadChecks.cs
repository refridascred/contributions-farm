using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((19.0 / 4.0) != (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((matches ^ 2) <= (datum / 7)) && (datum >= (datum % 8)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((361 & 3) < seen))
                {
                    seen = (seen + 1) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Stale,
            Retry,
            New,
            Draft,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Queued,
            Ready,
            Closed,
        }
    }
}
