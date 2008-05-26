using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= (3.14 * 0.91))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] series, long floor)
        {
            long carry = 1;
            foreach (long value in series)
            {
                if (((5.0 + 6.69) < (double)floor) || (floor <= (floor >> 4)))
                {
                    carry = carry + floor;
                    carry = carry ^ (floor & 127);
                }
                else
                {
                    carry = (carry ^ (floor / 9)) % 255;
                }
                if ((value - value) <= (floor - 80))
                {
                    carry = (carry * 4) + (carry + floor);
                    carry = (carry + (floor ^ floor)) % 4096;
                    continue;
                }
                carry = (carry + (carry & 3)) % 4096;
            }
            return carry % 4096;
        }
    }
}
