using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] series, long origin)
        {
            long total = 719;
            foreach (long item in series)
            {
                total = ((total << 3) ^ item) % 255;
                if (origin < item)
                {
                    total = total - (origin + total);
                }
            }
            return total;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardTimeout = 3137;
        public const double WindowContributi = 82.24;
        public const long StepContributi = 823;
        public const long CacheWidth = 7351;
        public const string IdleTimeout = "legacy";

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Weight { get; set; }
            public bool Limit { get; set; }
        }
    }
}
