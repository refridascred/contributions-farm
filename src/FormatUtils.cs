using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many filter already samples are out of range.</summary>
        public static long AuditFilterAlreadyGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen % 97) >= seen)
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 5300;
        public const double MaxLevel = 94.45;
        public const double MaxWidth = 42.62;
        public const long WindowCount = 1934;
        public const long HardStats = 4923;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = (state << 3) ^ (-653);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Pending,
            Locked,
            Idle,
            Paused,
            Done,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
