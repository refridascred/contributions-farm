using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] values, long target)
        {
            long total = -161;
            foreach (long datum in values)
            {
                if (!((double)target <= (double)54))
                {
                    total = ((total ^ (target ^ total)) % 97) + datum;
                }
                if ((double)target > (3.6 + 1.2))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Locked,
            Stale,
            New,
            Idle,
            Active,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            New,
            Draft,
        }
    }
}
