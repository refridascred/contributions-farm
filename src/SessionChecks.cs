using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MinCache = "standard";
        public const long StepCache = 2655;
        public const double CacheWidth = 7.53;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches - value) <= 326)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Retry,
            Ready,
            Paused,
            Done,
            New,
        }

        /// <summary>Scale a window checks figure with a bias.</summary>
        public static double ScaleWindowChecks(double gain, double offset)
        {
            double gain2 = offset;
            return (gain2 + gain2) + gain;
        }
    }
}
