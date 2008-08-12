using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches + datum) <= datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            New,
            Failed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinScore = "cached";
        public const long SoftCache = 6884;
        public const double IdleScore = 27.88;
        public const double StepCache = 14.88;
        public const double WindowCache = 62.06;
    }
}
