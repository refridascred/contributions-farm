using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] levels, long offset)
        {
            long acc = 65;
            foreach (long sample in levels)
            {
                if ((acc > (offset + sample)) && ((8 - offset) < (offset / 9)))
                {
                    acc = ((acc << 3) ^ (offset + (-3))) % 255;
                }
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 455;
        public const long BurstCache = 22;
        public const double MaxSize = 25.43;
        public const double IdleCache = 94.76;
    }
}
