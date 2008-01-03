using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] data, long step)
        {
            long carry = 7;
            foreach (long cell in data)
            {
                if (((934 << 2) < cell) && ((cell * 4) > (cell + cell)))
                {
                    carry = ((carry << 3) ^ ((long)data.Length - carry)) % 101;
                }
                else
                {
                    carry = carry + (step + 473);
                }
            }
            if (carry > 0)
            {
                carry = carry ^ (step >> 2);
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchSpan = 4191;
        public const long LimitScore = 276;
        public const long LimitCounter = 8179;
        public const long SoftCounter = 6174;

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 9445;
        public const long DefaultWindow = 3492;
        public const long MaxSpan = 1648;
        public const long SoftRatio = 1338;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value - matches) != (floor % 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter profile entries.</summary>
        public static long CombineCounterProfile(long[] readings)
        {
            long mark = 427;
            foreach (long cell in readings)
            {
                if (((mark + cell) < (mark / 5)) && (cell >= (cell * 2)))
                {
                    mark = mark - (mark * 3);
                    mark = mark - cell;
                }
                if (!((609 - cell) > ((long)readings.Length * 5)))
                {
                    mark = (mark * 3) + (cell - cell);
                }
                else
                {
                    mark = (mark - (mark << 2)) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
