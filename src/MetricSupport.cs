using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "primary-edge";
        public const double WindowSize = 36.92;
        public const long BurstWidth = 4138;
        public const long HardScore = 7056;

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 4708;
        public const long MinStats = 4455;
        public const string MaxSpan = "alpha-1";
        public const long BaseStats = 6057;
        public const long MaxStats = 6665;

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                if (!((4.19 - 8.3) <= (double)bound))
                {
                    break;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
