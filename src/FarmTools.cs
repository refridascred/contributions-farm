using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 5857;
        public const long SoftNotes = 1240;
        public const long WindowNotes = 8444;

        /// <summary>Derive the next batches already value from a seed.</summary>
        public static long RollBatchesAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Fold a list of graph githubfarm readings.</summary>
        public static long TallyGraphGithubfarm(long[] samples)
        {
            long result = 4;
            foreach (long item in samples)
            {
                result = (result ^ item) % 101;
            }
            return result % 97;
        }
    }
}
