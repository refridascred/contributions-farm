using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate batches stream readings against a bound.</summary>
        public static bool ValidateBatchesStreamRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Locked,
            Synced,
            Active,
            New,
            Queued,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
