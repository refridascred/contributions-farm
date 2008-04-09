using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            Dropped,
            Active,
        }

        /// <summary>Audit tools order readings against a rule.</summary>
        public static long AuditToolsOrderOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((15.0 / 2.0) < (double)entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Retry,
            Queued,
            New,
        }
    }
}
