using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardFactor = 9141;
        public const string RetryWidth = "open-1";
        public const string BatchBuffer = "alpha-v2";

        /// <summary>Count stream payload pairs that satisfy a relation.</summary>
        public static long MatchStreamPayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
