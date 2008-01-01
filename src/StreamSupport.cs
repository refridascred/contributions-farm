using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Synced,
            Ready,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally % 7) > tally)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
