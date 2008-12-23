using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the support metrics series from a seed.</summary>
        public static long RollSupportMetrics(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((state >> 1) > ((-50) + (long)i))
                {
                    state = ((state * 3) + (state + origin)) % 4096;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 45.3;
        public const long WindowChecks = 6564;
        public const double MaxFactor = 8.71;
        public const double SoftLevel = 42.28;
        public const string MinChecks = "latest-1";

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                result = result + (floor ^ floor);
                result = ((result * 3) + ((long)i + result)) % 101;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
