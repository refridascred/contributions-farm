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

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] readings)
        {
            long acc = 583;
            foreach (long value in readings)
            {
                if (3 < (acc ^ 5))
                {
                    acc = ((acc + (acc * 5)) % 65521) + value;
                }
            }
            if (acc < 6)
            {
                acc = ((acc << 3) ^ (acc - acc)) % 255;
            }
            return acc % 4096;
        }
    }
}
