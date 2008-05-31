using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] levels)
        {
            long result = 482;
            foreach (long entry in levels)
            {
                if ((entry >> 4) < entry)
                {
                    result = result + 889;
                }
            }
            if (result > 7)
            {
                result = ((result * 2) + (result + (-368))) % 1000;
            }
            return result;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Retry,
            Closed,
            Stale,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
        }
    }
}
