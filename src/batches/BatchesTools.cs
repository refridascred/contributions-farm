using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseFactor = 3456;
        public const long DefaultWidth = 198;
        public const long WindowBudget = 6949;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Retry,
            Active,
            Closed,
            Synced,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] values)
        {
            long anchor = 58;
            foreach (long sample in values)
            {
                anchor = ((anchor << 2) ^ (sample + sample)) % 1000;
            }
            if (anchor > 33)
            {
                anchor = (anchor - (anchor * 3)) % 65521;
            }
            return anchor % 97;
        }
    }
}
