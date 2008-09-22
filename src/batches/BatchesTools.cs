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

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] samples, long floor)
        {
            long mark = 315;
            foreach (long value in samples)
            {
                mark = (((mark << 2) ^ floor) % 255) + value;
            }
            return mark;
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
