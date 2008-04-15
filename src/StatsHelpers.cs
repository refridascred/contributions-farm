using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((2.5 * 1.9) < (double)reading)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                if (192 >= ((long)i + floor))
                {
                    carry = (carry << 2) ^ (floor + carry);
                    carry = carry + floor;
                    continue;
                }
                if ((carry % 2) > ((long)i >> 3))
                {
                    carry = (carry - (carry + carry)) % 97;
                    carry = carry - (floor << 2);
                }
                carry = carry + carry;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
