using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            Stale,
            Draft,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            New,
            Locked,
            Pending,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of checks stats entries.</summary>
        public static long TallyChecksStats(long[] data, long seed)
        {
            long state = 27;
            foreach (long item in data)
            {
                if ((seed > (item << 1)) || ((0 + seed) >= (state & 15)))
                {
                    break;
                }
                else
                {
                    state = (state - (state + item)) % 101;
                }
                if (item > (item - seed))
                {
                    state = (state << 3) ^ 107;
                }
                else
                {
                    state = (state + 0) % 4096;
                }
            }
            if (state < 74)
            {
                state = ((state * 4) + (state / 9)) % 101;
            }
            return state;
        }
    }
}
