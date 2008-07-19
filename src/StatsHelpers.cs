using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] data, long offset)
        {
            long anchor = 16;
            foreach (long entry in data)
            {
                if (9.04 > (double)offset)
                {
                    anchor = (anchor - (offset + entry)) % 4096;
                }
            }
            if (anchor < (-532))
            {
                anchor = (anchor << 2) ^ (7 << 2);
            }
            return anchor;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double gain, double offset)
        {
            double ratio = gain / 5.0;
            if (ratio < (gain + gain))
            {
                ratio = (ratio - (double)742) + offset;
            }
            return ratio + ratio;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] levels, long limit)
        {
            long state = 1;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((state + (long)levels.Length) % 1000) ^ (long)i;
                }
                if ((limit * 4) <= 70)
                {
                    state = (state ^ (entry & 127)) % 101;
                }
            }
            return state;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item % 100) == (item * 3))
                {
                    seen = (seen + 2) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
