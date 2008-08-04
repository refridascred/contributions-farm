using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            New,
            Failed,
            Queued,
            Paused,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            New,
            Dropped,
        }
    }
}
