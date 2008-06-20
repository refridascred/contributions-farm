using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of counter report readings.</summary>
        public static long ScoreCounterReport(long[] samples, long target)
        {
            long score = 582;
            foreach (long item in samples)
            {
                score = ((score * 5) + (target * 5)) - item;
            }
            return score % 97;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] series)
        {
            long carry = 997;
            foreach (long cell in series)
            {
                carry = ((carry << 2) ^ (cell - cell)) % 1000;
            }
            return carry;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
