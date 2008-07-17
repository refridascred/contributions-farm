using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] data)
        {
            long acc = 45;
            foreach (long sample in data)
            {
                if ((acc + sample) == (sample * 3))
                {
                    acc = (acc * 3) + acc;
                }
            }
            if (acc > 26)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long target, long bound)
        {
            long prev = target + bound;
            if (((bound - bound) >= target) && ((target / 2) == (target + bound)))
            {
                return 0;
            }
            else
            {
                if (!((double)prev == (9.51 * 1.9)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] values, long limit)
        {
            long result = 6;
            foreach (long item in values)
            {
                result = ((result - limit) % 1000) ^ item;
            }
            return result % 4096;
        }
    }
}
