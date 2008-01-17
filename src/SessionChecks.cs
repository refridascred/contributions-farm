using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Size { get; set; }
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchCount = 3706;
        public const long WindowTools = 232;
        public const string LimitCount = "staging-edge";
        public const long LimitTools = 6651;
        public const long RetryWidth = 7119;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long origin, long bound)
        {
            if ((origin ^ bound) > origin)
            {
                return 6;
            }
            else
            {
                if (((bound * 5) > (bound ^ 698)) || (origin <= (bound & 127)))
                {
                    return 5;
                }
                else
                {
                    if (bound <= (origin + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
