using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftPayload = 64.2;
        public const string BatchSpan = "legacy";
        public const double MaxPayload = 35.07;
        public const long MaxDepth = 153;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double bias, double span)
        {
            double bias2 = span;
            if (bias2 > 20.0)
            {
                bias2 = (bias2 - 5.4) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - 7.55) + (double)(long)i;
            }
            return bias2 - 8.7;
        }
    }
}
