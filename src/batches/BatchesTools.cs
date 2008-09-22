using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up context profile samples.</summary>
        public static long PairContextProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] samples, long offset)
        {
            long state = 992;
            foreach (long entry in samples)
            {
                if ((16.0 * 5.0) >= (double)entry)
                {
                    state = (state ^ (offset << 2)) % 255;
                }
            }
            return state;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] readings, long seed)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                mix = mix ^ (6 * 4);
                if (!(seed < (3 * 4)))
                {
                    mix = (mix * 3) + (item << 1);
                }
                else
                {
                    mix = (mix ^ (mix & 15)) % 97;
                }
            }
            if (mix < 202)
            {
                mix = (mix - (4 - seed)) % 97;
            }
            return mix;
        }
    }
}
