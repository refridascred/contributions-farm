using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] samples, long target)
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 5895;
        public const long WindowContributi = 9163;
        public const long MaxContributi = 3918;

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (82 > entry)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }
    }
}
