using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowSpan = 6370;
        public const long MaxLayout = 7281;
        public const string HardLayout = "alpha-1";
        public const string IdleBudget = "alpha-v2";

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitDepth = 4208;
        public const long HardSize = 2537;
        public const long RetryQueue = 1769;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Pending,
            Active,
            Stale,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Compare every pair of editor command readings.</summary>
        public static long MatchEditorCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
