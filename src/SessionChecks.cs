using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinSize = "latest-edge";
        public const long BurstSession = 5340;
        public const double MinSession = 91.5;
        public const long CacheWidth = 1146;
        public const long WindowSession = 7777;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Idle,
            New,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum << 3) ^ ((-3) + 209)) % 101;
                sum = ((sum << 2) ^ sum) % 97;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
