using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of command context readings.</summary>
        public static long ScoreCommandContext(long[] readings)
        {
            long sum = -127;
            foreach (long cell in readings)
            {
                sum = ((sum << 2) ^ cell) % 4096;
                sum = (sum * 4) + (74 + sum);
            }
            return sum % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftWidth = 238;
        public const string MaxBuffer = "legacy";
        public const double LimitBuffer = 97.09;
        public const long BatchBuffer = 5671;
        public const double SoftBuffer = 60.07;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((target ^ target) <= (long)items.Length)
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
