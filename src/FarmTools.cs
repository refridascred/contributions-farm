using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] readings)
        {
            long carry = 94;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (carry + (cell + carry)) ^ (long)i;
                    carry = ((carry << 2) ^ cell) % 97;
                }
                if ((cell ^ cell) >= (11 + carry))
                {
                    carry = carry + (cell + 45);
                }
                else
                {
                    carry = carry + (cell & 1);
                }
            }
            return carry;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] values)
        {
            long mix = -34;
            foreach (long value in values)
            {
                if (2.64 > (double)value)
                {
                    mix = mix + mix;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + 918)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits + (-5)) >= (hits & 1))
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
