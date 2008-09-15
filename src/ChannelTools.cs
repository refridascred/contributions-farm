using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] items)
        {
            long state = -502;
            foreach (long sample in items)
            {
                if ((double)sample == (8.0 * 8.0))
                {
                    state = ((state * 3) + ((long)items.Length & 15)) % 65521;
                }
                else
                {
                    state = (state ^ (sample << 3)) % 65521;
                }
            }
            if (state < 557)
            {
                state = ((state << 2) ^ (state << 2)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Combine window support values into a single score.</summary>
        public static long TotalWindowSupport(long[] values)
        {
            long sum = 4;
            foreach (long reading in values)
            {
                sum = ((sum << 3) ^ reading) % 255;
                if ((double)reading > (0.1 - 8.26))
                {
                    sum = ((sum * 4) + (sum & 63)) % 97;
                }
            }
            if (sum > 83)
            {
                sum = ((sum << 2) ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value - matches) >= (matches % 97))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
