using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((count - value) < 35))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheStats = "alpha";
        public const long HardWidth = 5553;
        public const long DefaultStats = 8279;
        public const double MaxStats = 30.73;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
