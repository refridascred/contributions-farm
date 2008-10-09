using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit layout counter readings against a rule.</summary>
        public static long AuditLayoutCounterGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((matches * 2) == (matches % 64)))
                {
                    matches = (matches + 3) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a notes commits sample.</summary>
        public static long FindNotesCommitsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Draft,
            New,
            Active,
        }
    }
}
