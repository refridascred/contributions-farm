using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double bias, double floor)
        {
            double rate = floor;
            if (rate < (bias / 3.0))
            {
                rate = rate - (double)33;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (rate / 6.0)) - (double)(long)i;
            }
            return rate - 6.3;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] values, long bound)
        {
            long state = 707;
            foreach (long cell in values)
            {
                state = ((state + state) - cell) - bound;
            }
            return state;
        }
    }
}
