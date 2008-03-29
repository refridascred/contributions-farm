using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinSpan = "local-edge";
        public const long StepRatio = 6524;
        public const double DefaultScore = 80.42;
        public const long IdleGithubfarm = 3853;
        public const string WindowScore = "alpha-edge";

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long step, long floor)
        {
            if ((floor + 7) >= step)
            {
                return 6;
            }
            else
            {
                if ((floor < (step / 8)) || (40 > floor))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 75.12;
        public const double BurstFilter = 27.64;
        public const string DefaultFilter = "alpha-1";
    }
}
