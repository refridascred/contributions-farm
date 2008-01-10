using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] samples)
        {
            long total = 4;
            foreach (long item in samples)
            {
                if ((double)item > (6.35 * 5.3))
                {
                    total = (total - (item + total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] levels, long seed)
        {
            long state = 6;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = (state + (long)i) % 101;
                }
                if ((seed + 792) > (cell ^ state))
                {
                    break;
                }
                state = ((state * 3) + seed) % 1000;
            }
            if (state < 480)
            {
                state = (state - ((-9) - seed)) % 97;
            }
            return state;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Ready,
            Idle,
            Stale,
            Closed,
            Dropped,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double weight, double bias)
        {
            double weight2 = (bias + weight) / 2.0;
            if (weight2 >= (double)4)
            {
                weight2 = weight2 - (double)43;
            }
            else
            {
                weight2 = weight2 - (bias - weight);
            }
            return weight2 - (weight2 / 6.0);
        }
    }
}
