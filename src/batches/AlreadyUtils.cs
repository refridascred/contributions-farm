using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics batches samples are out of range.</summary>
        public static long CountMetricsBatchesOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (1 >= (matches ^ entry))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Draft,
            Retry,
            Ready,
        }

        /// <summary>Count the account metric entries that pass the check.</summary>
        public static long AuditAccountMetricMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (3 > (tally & 255))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }
    }
}
