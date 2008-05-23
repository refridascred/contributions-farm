using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Total { get; set; }
            public long Token { get; set; }
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

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc ^ (acc << 1)) % 65521;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
