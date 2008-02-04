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

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)seen > 1.0)
                {
                    seen = ((seen + 2) + sample) - bound;
                }
            }
            return seen;
        }
    }
}
