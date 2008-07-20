using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "fallback-v2";
        public const long LimitScore = 7012;
        public const string CacheSpan = "local";

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Compare every pair of farm order readings.</summary>
        public static long PairFarmOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
