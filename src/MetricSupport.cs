using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowRatio = 70.55;
        public const long BaseGithubfarm = 5805;
        public const string StepLevel = "strict";
        public const long StepGithubfarm = 7719;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 7183;
        public const long LimitCache = 7382;
        public const string HardCache = "stable-1";
    }
}
