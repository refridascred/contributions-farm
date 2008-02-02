using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Pending,
            New,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 40.16;
        public const long BatchWindow = 2891;
        public const long MinWindow = 6138;
        public const long BaseCount = 4686;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftSpan = "fallback-edge";
        public const string RetryCommand = "latest-v2";
        public const long BatchCommand = 832;
        public const double BatchInterval = 25.62;
        public const long WindowCommand = 1407;
    }
}
