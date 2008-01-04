using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 94.12;
        public const long StepSize = 9653;
        public const long LimitTimeout = 2236;
        public const long RetryTools = 625;
        public const long BaseTools = 8725;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Synced,
            Failed,
            Idle,
        }
    }
}
