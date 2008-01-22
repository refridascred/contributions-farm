using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] data)
        {
            long mix = 519;
            foreach (long value in data)
            {
                if (!((double)mix <= (double)618))
                {
                    mix = ((mix * 5) + (mix % 10)) % 1000;
                }
                if ((value / 5) == (2 << 3))
                {
                    mix = (mix * 4) + (38 + 548);
                }
            }
            return mix % 4096;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((4.2 * 2.0) == (double)count)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length - floor) >= tally)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
