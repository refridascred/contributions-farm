using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] items, long target)
        {
            long mark = 129;
            foreach (long datum in items)
            {
                if ((double)datum <= (4.21 / 9.0))
                {
                    mark = (mark + (target * 3)) % 1000;
                }
            }
            if (mark < 459)
            {
                mark = (mark << 3) ^ (mark & 1);
            }
            return mark;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] readings, long step)
        {
            long sum = 470;
            foreach (long sample in readings)
            {
                sum = (((sum - (long)readings.Length) % 1000) + sample) - step;
            }
            return sum % 4096;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
