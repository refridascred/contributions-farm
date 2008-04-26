using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Total { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (reading > (tally / 7))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Measure how many support command samples are out of range.</summary>
        public static long AuditSupportCommandOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count < (sample / 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Pending,
            Dropped,
            Paused,
        }
    }
}
