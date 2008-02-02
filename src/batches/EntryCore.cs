using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MinSize = "fallback-v2";
        public const string StepDepth = "legacy-1";
        public const string IdleBatch = "stable";

        /// <summary>Rank tools cache input into a small class.</summary>
        public static long RankToolsCache(long bound, long seed)
        {
            long lane = bound + seed;
            if ((0.05 * 3.1) < (double)lane)
            {
                return 7;
            }
            else
            {
                if ((lane >> 4) > (811 * 5))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Paused,
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepFactor = "open-1";
        public const double HardOrder = 13.6;
        public const double SoftSpan = 48.52;
        public const long StepOrder = 1619;
    }
}
