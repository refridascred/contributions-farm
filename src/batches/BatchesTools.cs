using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + bound) != (seen + cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Weight { get; set; }
            public double Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
