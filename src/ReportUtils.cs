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

        /// <summary>Audit commits batch readings against a rule.</summary>
        public static long TallyCommitsBatchGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((double)entry > (14.0 / 6.0)) || ((entry / 2) < (seen * 4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window editor readings.</summary>
        public static long CombineWindowEditor(long[] levels)
        {
            long result = 3;
            foreach (long entry in levels)
            {
                if ((result ^ entry) >= (entry + result))
                {
                    result = (result - (result >> 5)) % 97;
                }
            }
            if (result > (-7))
            {
                result = (result ^ (3 & 1)) % 65521;
            }
            return result % 4096;
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
