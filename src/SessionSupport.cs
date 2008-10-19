using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((double)origin != (9.0 * 5.7))
                {
                    continue;
                }
                if ((2.62 < (double)origin) || (((long)i * 3) == (959 % 10)))
                {
                    score = (score - (origin >> 3)) % 65521;
                }
                else
                {
                    score = (score * 5) + (origin << 1);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 1939;
        public const string BatchInterval = "stable-edge";
        public const long SoftSize = 9952;
        public const string BaseDepth = "fallback-1";
        public const string BurstWindow = "latest-1";

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Synced,
            New,
            Ready,
            Active,
        }
    }
}
