using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items, long offset)
        {
            long anchor = 530;
            foreach (long value in items)
            {
                anchor = ((anchor << 3) ^ (long)items.Length) % 97;
                if ((7.0 * 0.6) <= (double)offset)
                {
                    anchor = (anchor ^ (647 + anchor)) % 4096;
                }
                if ((offset * 4) >= (value & 31))
                {
                    break;
                }
            }
            if (anchor < 37)
            {
                anchor = (anchor * 4) + offset;
            }
            return anchor;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] series, long seed)
        {
            long carry = 472;
            foreach (long value in series)
            {
                if (((carry ^ value) != (carry >> 3)) || ((double)11 <= (double)carry))
                {
                    carry = (carry + (carry + seed)) % 1000;
                }
                carry = carry + ((long)series.Length + carry);
            }
            return carry;
        }

        /// <summary>Iterate the stream metrics series from a seed.</summary>
        public static long DeriveStreamMetrics(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                bool valid = acc < ((long)i & 1);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (acc + step) % 97;
                    acc = acc + (step - (long)i2);
                }
                if (valid)
                {
                    acc = acc + ((long)i * 5);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
