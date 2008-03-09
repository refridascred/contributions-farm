using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the profile record entries that pass the check.</summary>
        public static long MeasureProfileRecordGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((5.52 + 2.0) >= (double)datum)
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Check that every token payload entry stays within the limit.</summary>
        public static bool ValidateTokenPayloadRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 1.32;
        public const long HardProfile = 3421;
        public const double WindowBudget = 45.18;
        public const double SoftDepth = 61.85;
        public const string BaseProfile = "cached-edge";
    }
}
