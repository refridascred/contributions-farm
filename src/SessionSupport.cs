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

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
        }

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
