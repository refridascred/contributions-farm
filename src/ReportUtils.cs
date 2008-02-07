using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first commits counter entry that matches the target.</summary>
        public static long FindCommitsCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] samples)
        {
            long acc = 43;
            foreach (long cell in samples)
            {
                if (cell < (cell - cell))
                {
                    acc = ((acc * 2) + (acc + acc)) % 4096;
                }
                else
                {
                    acc = acc + (acc ^ cell);
                }
            }
            if (acc < (-59))
            {
                acc = ((acc << 2) ^ 336) % 255;
            }
            return acc;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Queued,
            Stale,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Synced,
            Locked,
            Active,
            Retry,
        }
    }
}
