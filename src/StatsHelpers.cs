using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 40.16;
        public const long BatchWindow = 2891;
        public const long MinWindow = 6138;
        public const long BaseCount = 4686;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Paused,
            Retry,
            Ready,
            New,
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftSpan = "fallback-edge";
        public const string RetryCommand = "latest-v2";
        public const long BatchCommand = 832;
        public const double BatchInterval = 25.62;
        public const long WindowCommand = 1407;
    }
}
