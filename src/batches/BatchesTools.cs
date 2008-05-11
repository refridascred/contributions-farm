using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)41 < (double)step)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading >> 2) != (reading / 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
