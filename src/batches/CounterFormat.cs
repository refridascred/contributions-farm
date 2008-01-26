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

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseInterval = "standard-edge";
        public const double MaxSpan = 8.81;
        public const long DefaultCommits = 6254;
        public const long WindowCommits = 8333;
        public const long BaseCommits = 5349;
    }
}
