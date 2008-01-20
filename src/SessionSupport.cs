using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 97.54;
        public const long IdleGithubfarm = 7695;
        public const long StepGithubfarm = 3247;
        public const long WindowGithubfarm = 8375;
        public const double BaseGithubfarm = 40.5;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Paused,
            Dropped,
            Active,
            Idle,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double gain, double span)
        {
            double load = span;
            if (load <= (double)716)
            {
                load = (load + span) + gain;
            }
            else
            {
                load = load + span;
            }
            return load + (load - 9.0);
        }
    }
}
