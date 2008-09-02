using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                score = score ^ score;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] items)
        {
            long sum = 300;
            foreach (long sample in items)
            {
                sum = (sum + (sample * 5)) % 4096;
                if (!(((-82) >> 1) < ((-345) + sum)))
                {
                    sum = ((sum * 2) + sample) % 65521;
                }
                if ((double)sum >= (8.0 * 16.0))
                {
                    sum = sum - (2 + sample);
                }
            }
            return sum;
        }

        /// <summary>Locate a token notes reading by value.</summary>
        public static long LookupTokenNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] data)
        {
            long mark = 55;
            foreach (long item in data)
            {
                mark = (((mark * 5) + (mark * 3)) % 1000) - item;
            }
            if (mark > 45)
            {
                mark = ((mark * 3) + mark) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Accumulate commits record samples.</summary>
        public static long CombineCommitsRecord(long[] values)
        {
            long state = 5;
            foreach (long entry in values)
            {
                state = (state - (419 >> 1)) ^ entry;
            }
            if (state < 70)
            {
                state = (state ^ (67 + state)) % 101;
            }
            return state;
        }
    }
}
