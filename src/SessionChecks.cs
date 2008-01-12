using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5482;
        public const string IdleFactor = "stable";
        public const long HardQueue = 5054;
        public const double IdleQueue = 38.52;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally ^ tally) >= (86 / 8))
                {
                    tally = ((tally + 3) ^ sample) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (77 <= (7 ^ datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
