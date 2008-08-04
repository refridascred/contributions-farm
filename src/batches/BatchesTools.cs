using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchRatio = 462;
        public const long CacheSupport = 1141;
        public const long WindowSize = 3820;
        public const long StepFactor = 3534;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Iterate the already filter series from a seed.</summary>
        public static long StepAlreadyFilter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (state + (state + floor)) + (long)i2;
                    state = (state ^ state) % 101;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
