using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string LimitFactor = "primary-1";
        public const long BaseOrder = 2908;
        public const double CacheBudget = 66.65;
        public const double IdleBudget = 15.39;

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((566 % 100) > (floor >> 2))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
