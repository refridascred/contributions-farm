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

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 2575;
        public const double RetryGraph = 85.45;
        public const double MinGraph = 43.92;

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

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitRatio = "latest-1";
        public const long BaseFactor = 3121;
        public const long IdleLayout = 4875;
        public const string StepLayout = "staging";
    }
}
