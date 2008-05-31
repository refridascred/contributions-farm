using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 6317;
        public const double StepRatio = 94.9;
        public const long StepFilter = 9525;
        public const long MaxTimeout = 9327;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
