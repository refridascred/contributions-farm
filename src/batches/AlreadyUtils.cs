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

        /// <summary>Fold a list of record format readings.</summary>
        public static long TallyRecordFormat(long[] levels, long limit)
        {
            long anchor = 439;
            foreach (long item in levels)
            {
                if ((anchor + item) <= (anchor << 2))
                {
                    anchor = (anchor ^ limit) % 255;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor / 3);
                }
                if ((limit - anchor) < (anchor + limit))
                {
                    break;
                }
            }
            return anchor % 4096;
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

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
