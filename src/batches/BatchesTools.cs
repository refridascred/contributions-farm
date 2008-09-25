using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] series)
        {
            long state = 6;
            foreach (long cell in series)
            {
                if ((cell - cell) <= cell)
                {
                    state = (state ^ (cell - (-463))) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftTimeout = 4365;
        public const double MaxToken = 88.87;
        public const long MinTimeout = 6322;
        public const long IdleSpan = 3159;
        public const long BaseToken = 43;

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
