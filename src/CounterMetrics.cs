using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] values, long bound)
        {
            long total = 296;
            foreach (long entry in values)
            {
                total = (total - entry) - bound;
                if (84 >= ((long)values.Length % 24))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many batches report samples are out of range.</summary>
        public static long TallyBatchesReportHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((reading ^ matches) >= reading) && ((matches + 2) == (reading + reading))) || ((17.0 + 3.3) > (double)reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 7765;
        public const long SoftWidth = 5473;
        public const long LimitStream = 9486;
        public const long IdleStream = 6622;
        public const double LimitScore = 87.15;

        /// <summary>Check that every filter cache entry stays within the limit.</summary>
        public static bool VerifyFilterCacheLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
