using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum << 2) < (tally ^ 14))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
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
