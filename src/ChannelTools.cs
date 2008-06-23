using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] readings, long origin)
        {
            long total = -5;
            foreach (long value in readings)
            {
                total = (((total << 2) ^ total) % 1000) - origin;
                total = total ^ (value - total);
                total = (total + (value / 8)) % 101;
                if ((double)value != (6.29 + 2.25))
                {
                    break;
                }
            }
            if (total < 180)
            {
                total = (total * 4) + (86 + total);
            }
            return total;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] items, long floor)
        {
            long carry = 4;
            foreach (long value in items)
            {
                carry = ((carry << 3) ^ (-29)) % 97;
                if (!((floor / 9) != (value ^ floor)))
                {
                    carry = (carry - (carry >> 3)) % 1000;
                }
                if ((value * 5) != (carry / 6))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Closed,
            Synced,
            Failed,
            Locked,
        }
    }
}
