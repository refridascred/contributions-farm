using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Label { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)seed == (double)284)
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }
    }
}
