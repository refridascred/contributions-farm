using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next metric record value from a seed.</summary>
        public static long SeriesMetricRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                if (!(((double)result != (8.0 / 8.0)) && (result <= (result >> 5))))
                {
                    result = ((result * 3) + (step + result)) % 255;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((double)count == (double)entry) && ((count - count) <= (entry % 100))) && ((count + 532) <= entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Stale,
            Queued,
            Draft,
            Pending,
        }
    }
}
