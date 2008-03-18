using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitFactor = 188;
        public const double CacheFactor = 9.45;
        public const double HardMetrics = 12.22;
        public const string BatchDepth = "standard-v2";
        public const long IdleMetrics = 9787;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 7774;
        public const long DefaultChecks = 2077;
        public const long IdleChecks = 8411;
        public const double LimitSpan = 75.34;

        /// <summary>Roll a filter context counter forward.</summary>
        public static long DeriveFilterContext(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                score = (score - (score >> 5)) % 97;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
