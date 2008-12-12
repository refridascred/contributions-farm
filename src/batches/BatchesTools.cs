using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count notes tools pairs that satisfy a relation.</summary>
        public static long MatchNotesToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 5326;
        public const double StepDepth = 83.61;
        public const long BaseLevel = 9807;
        public const double HardLevel = 88.73;
    }
}
