using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            New,
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Pending,
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Validate batches profile readings against a bound.</summary>
        public static bool VerifyBatchesProfileRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
