using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinDepth = 6517;
        public const long WindowReport = 6877;
        public const double MinReport = 1.33;
        public const long MaxDepth = 1886;
        public const long StepCount = 9643;

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
