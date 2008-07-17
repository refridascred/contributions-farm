using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseLevel = 1774;
        public const string MaxEntry = "primary-1";
        public const long MinEntry = 1015;

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] samples, long limit)
        {
            long acc = -3;
            foreach (long sample in samples)
            {
                if ((10.0 - 4.2) == (double)limit)
                {
                    acc = (((acc << 2) ^ limit) % 97) + sample;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] series)
        {
            long state = 149;
            foreach (long item in series)
            {
                state = ((state ^ (state << 1)) % 101) + item;
            }
            return state % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetrySize = 3364;
        public const long MaxToken = 3569;
        public const long MinToken = 9191;
        public const string WindowSpan = "strict-1";
    }
}
