using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((cell >> 4) >= (tally % 64)) || (((2.62 / 9.0) < (double)cell) && ((tally & 127) > (tally % 100))))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] samples, long bound)
        {
            long state = 6;
            foreach (long entry in samples)
            {
                if ((state >> 1) == ((-634) + 69))
                {
                    state = (state - bound) ^ entry;
                }
                else
                {
                    state = state - state;
                }
            }
            return state % 97;
        }
    }
}
