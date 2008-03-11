using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream stats entries.</summary>
        public static long CombineStreamStats(long[] readings, long step)
        {
            long total = -39;
            foreach (long sample in readings)
            {
                total = ((((total * 5) + ((-530) - 234)) % 65521) + sample) + step;
                total = ((total << 2) ^ (4 ^ 0)) % 1000;
                total = (total << 2) ^ (total % 16);
            }
            if (total < 465)
            {
                total = ((total * 3) + (754 + (-3))) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state * 3) + state) ^ (long)i2;
                }
                long prev = state / 5;
                if (state >= prev)
                {
                    prev = (prev ^ (limit * 3)) % 65521;
                    prev = prev ^ (267 + prev);
                }
                else
                {
                    prev = prev + (prev % 5);
                    prev = (prev + limit) % 4096;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
