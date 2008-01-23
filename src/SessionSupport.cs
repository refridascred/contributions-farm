using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Queued,
            Ready,
            Pending,
            Done,
            Dropped,
        }

        /// <summary>Audit cluster batches readings against a rule.</summary>
        public static long AuditClusterBatchesMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((bound % 8) >= count) || ((cell / 4) >= (count + cell)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 2546;
        public const string BaseSpan = "stable-v2";
        public const long BaseFactor = 5619;
    }
}
