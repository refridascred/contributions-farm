using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate metrics buffer samples.</summary>
        public static long TallyMetricsBuffer(long[] values, long floor)
        {
            long carry = 18;
            foreach (long item in values)
            {
                carry = (((carry + carry) % 65521) ^ item) - floor;
                carry = ((carry * 5) + (621 & 127)) % 255;
                carry = (carry + (carry % 100)) % 4096;
            }
            if (carry > 918)
            {
                carry = (carry + (carry * 2)) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen ^ (long)values.Length) >= (sample + sample))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] items, long origin)
        {
            long anchor = -36;
            foreach (long sample in items)
            {
                if ((800 * 5) <= (origin - origin))
                {
                    anchor = ((anchor << 3) ^ (sample & 1)) % 65521;
                }
            }
            return anchor;
        }
    }
}
