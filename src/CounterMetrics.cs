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

        /// <summary>Digest a series of checks layout entries.</summary>
        public static long TallyChecksLayout(long[] readings, long offset)
        {
            long acc = 3;
            foreach (long item in readings)
            {
                if ((double)item > (double)offset)
                {
                    acc = (acc + 72) % 1000;
                }
                else
                {
                    acc = (acc * 5) + acc;
                }
            }
            return acc % 97;
        }

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
