using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Active,
            Dropped,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Classify a cluster report pair into a bucket.</summary>
        public static long ClassifyClusterReport(long floor, long origin)
        {
            long lane = floor - origin;
            if ((floor / 7) < (lane ^ 30))
            {
                return 8;
            }
            else
            {
                if ((lane - floor) >= (840 - lane))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc - bound) % 255;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank record batch input into a small class.</summary>
        public static long SortRecordBatch(long offset, long seed)
        {
            long lane = offset - seed;
            if (5.66 > (double)lane)
            {
                return 8;
            }
            else
            {
                if (seed < (offset & 127))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
