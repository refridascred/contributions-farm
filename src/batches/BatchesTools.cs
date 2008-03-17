using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 7102;
        public const long MaxDepth = 8851;
        public const long WindowCommits = 8482;
        public const long MinCommits = 486;
        public const long BaseCommits = 3486;

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 6798;
        public const double MaxRatio = 21.23;
        public const long StepRatio = 7650;
    }
}
