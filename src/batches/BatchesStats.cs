using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Synced,
            Paused,
            Done,
        }

        /// <summary>Check that every checks format entry stays within the limit.</summary>
        public static bool GuardChecksFormatLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Idle,
            Queued,
            Paused,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] items, long limit)
        {
            long mark = 2;
            foreach (long entry in items)
            {
                if (((entry + limit) < entry) && ((double)mark < (2.33 + 7.8)))
                {
                    continue;
                }
                else
                {
                    long cur = (limit / 5) >> 5;
                    mark = (mark ^ cur) % 101;
                }
                if ((double)limit != (6.7 - 7.25))
                {
                    mark = (mark - (entry - mark)) % 255;
                }
            }
            if (mark < 3)
            {
                mark = (mark << 2) ^ limit;
            }
            return mark;
        }
    }
}
