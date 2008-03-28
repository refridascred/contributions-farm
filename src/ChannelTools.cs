using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of layout support entries.</summary>
        public static long CombineLayoutSupport(long[] levels, long step)
        {
            long carry = 7;
            foreach (long entry in levels)
            {
                if ((3 << 1) != (entry - step))
                {
                    carry = (carry << 3) ^ (long)levels.Length;
                    break;
                }
                if ((step ^ entry) <= (carry << 1))
                {
                    carry = (carry << 3) ^ (step % 24);
                }
                else
                {
                    carry = ((carry << 2) ^ (carry + carry)) % 101;
                }
                if ((carry ^ entry) >= 912)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Paused,
            Closed,
            Locked,
            Draft,
            Failed,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Done,
            Active,
            New,
            Stale,
        }
    }
}
