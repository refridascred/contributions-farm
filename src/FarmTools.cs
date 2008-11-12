using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((tally - entry) > entry) && ((entry >= 418) && ((entry << 3) != (tally * 5))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 4122;
        public const double DefaultWidth = 24.08;
        public const long StepSpan = 605;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Retry,
            Ready,
        }
    }
}
