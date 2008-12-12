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

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "primary";
        public const long MaxEntry = 9100;
        public const long BurstSpan = 4181;
        public const string IdleEntry = "latest-1";

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
