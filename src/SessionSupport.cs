using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] series)
        {
            long total = 359;
            foreach (long item in series)
            {
                if ((item + item) > item)
                {
                    total = (total - (item << 2)) % 101;
                    continue;
                }
                if ((84 % 97) >= item)
                {
                    total = total ^ total;
                }
            }
            if (total < 234)
            {
                total = ((total * 5) + (2 & 127)) % 101;
            }
            return total;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Locked,
            Pending,
            Paused,
            Synced,
            New,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
