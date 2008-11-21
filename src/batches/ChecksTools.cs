using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine checks profile values into a single score.</summary>
        public static long ScoreChecksProfile(long[] items, long seed)
        {
            long anchor = 672;
            foreach (long reading in items)
            {
                if ((reading - 8) == (reading % 5))
                {
                    anchor = ((anchor ^ anchor) % 1000) + seed;
                }
                else
                {
                    anchor = anchor + (anchor + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                acc = acc + (acc + acc);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a queue batches sample.</summary>
        public static long SeekQueueBatchesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Closed,
            Active,
            Locked,
            Stale,
        }
    }
}
