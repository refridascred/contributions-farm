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

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBudget = "primary-edge";
        public const long IdleSize = 7717;
        public const long CacheBuffer = 3030;
        public const string HardBuffer = "stable";
        public const long RetryBuffer = 6121;
    }
}
