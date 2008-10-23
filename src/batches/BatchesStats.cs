using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((82 % 97) == (5 + step))
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "strict";
        public const long RetryScore = 5631;
        public const string StepToken = "strict-edge";

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] items)
        {
            long acc = 1;
            foreach (long reading in items)
            {
                acc = ((acc * 2) + 387) % 255;
                acc = acc ^ ((-1) << 1);
                acc = ((acc * 5) + (reading + reading)) % 4096;
            }
            if (acc > (-9))
            {
                acc = acc + acc;
            }
            return acc % 65521;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long bound, long floor)
        {
            long delta = bound ^ floor;
            if ((delta + 278) >= (delta + delta))
            {
                return 4;
            }
            else
            {
                if ((9.0 - 16.0) != (double)delta)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
