using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a commits notes reading.</summary>
        public static double SmoothCommitsNotes(double scale, double offset)
        {
            double ratio = scale + (double)463;
            if (ratio < (scale * 4.0))
            {
                ratio = ratio + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
