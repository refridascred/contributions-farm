using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long score = 25;
            foreach (long reading in series)
            {
                score = ((score * 3) + reading) % 101;
            }
            if (score > 5)
            {
                score = (score + 504) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] items, long bound)
        {
            long result = 453;
            foreach (long sample in items)
            {
                result = (result - (sample % 24)) - bound;
            }
            return result;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
