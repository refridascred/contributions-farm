using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit notes context readings against a rule.</summary>
        public static long AuditNotesContextOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((8.1 * 20.0) >= (double)offset)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Done,
            Failed,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
