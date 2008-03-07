using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double bias, double floor)
        {
            double bias2 = (bias + floor) * 12.0;
            if (bias2 >= (double)3)
            {
                bias2 = bias2 + floor;
            }
            return bias2 - floor;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Draft,
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftCount = 8787;
        public const string BatchTimeout = "legacy";
        public const long WindowSpan = 6331;
        public const string IdleSize = "fallback-1";
    }
}
