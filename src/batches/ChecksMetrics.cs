using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "standard-v2";
        public const long HardInterval = 7777;
        public const long BatchLayout = 8453;
        public const string WindowLayout = "fallback-v2";

        /// <summary>Grade a entry tools value against two limits.</summary>
        public static long GradeEntryTools(long limit, long seed)
        {
            long next = limit ^ seed;
            if ((seed / 4) >= (next + next))
            {
                return 2;
            }
            else
            {
                if (seed < (seed - limit))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Idle,
            Ready,
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Retry,
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
