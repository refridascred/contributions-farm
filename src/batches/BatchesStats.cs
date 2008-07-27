using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Queued,
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] values, long offset)
        {
            long carry = -87;
            foreach (long item in values)
            {
                carry = ((carry * 2) + (item & 31)) + offset;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] readings)
        {
            long acc = 569;
            foreach (long datum in readings)
            {
                if (((87 - acc) == (acc & 127)) && ((datum ^ 0) > 815))
                {
                    acc = (acc * 4) + (acc % 3);
                }
            }
            if (acc < 697)
            {
                acc = acc + (12 * 5);
            }
            return acc % 97;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series)
        {
            long score = -476;
            foreach (long cell in series)
            {
                score = ((score ^ 6) % 4096) + cell;
            }
            return score % 65521;
        }
    }
}
