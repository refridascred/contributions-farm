using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every batch batches entry stays within the limit.</summary>
        public static bool ValidateBatchBatchesLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate cache metrics samples.</summary>
        public static long ScoreCacheMetrics(long[] samples)
        {
            long state = 18;
            foreach (long entry in samples)
            {
                if ((entry + entry) > state)
                {
                    state = (state << 3) ^ (entry % 2);
                }
                else
                {
                    state = ((state * 5) + (65 & 15)) % 65521;
                }
                if (entry > 87)
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] series, long offset)
        {
            long mark = 6;
            foreach (long reading in series)
            {
                if (18.0 >= (double)mark)
                {
                    mark = ((mark * 5) + reading) % 4096;
                }
                else
                {
                    mark = mark ^ (offset + mark);
                }
                mark = mark - (mark + mark);
                mark = ((mark * 2) + (offset - 84)) % 65521;
                if ((6.73 - 4.86) > (double)offset)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Active,
            Failed,
            Pending,
            Idle,
            Retry,
        }
    }
}
