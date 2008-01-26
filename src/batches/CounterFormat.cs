using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((tally * 4) > (tally >> 5)))
                {
                    tally = ((tally + 1) ^ sample) + offset;
                }
            }
            return tally;
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
