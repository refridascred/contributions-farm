using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 5237;
        public const string StepContext = "strict-1";
        public const long DefaultFactor = 2094;

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                sum = sum ^ (target / 9);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "cached-v2";
        public const long DefaultSupport = 4828;
        public const string BaseCount = "strict-1";
        public const double IdleLevel = 31.47;
        public const double DefaultScore = 49.87;
    }
}
