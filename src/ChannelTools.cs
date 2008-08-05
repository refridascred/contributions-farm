using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = acc + (acc & 127);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultTimeout = 28.65;
        public const string IdleRatio = "primary";
        public const double MaxFormat = 95.59;
        public const long BaseLevel = 5256;
    }
}
