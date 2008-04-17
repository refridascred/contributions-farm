using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double StepCount = 71.26;
        public const long BatchStats = 8671;
        public const string WindowStats = "fallback-edge";

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 7961;
        public const long BaseCount = 7532;
        public const string SoftScore = "cached-1";

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double gain, double span)
        {
            double ratio = span;
            return ratio - gain;
        }
    }
}
