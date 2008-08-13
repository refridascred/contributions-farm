using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] values)
        {
            long score = 7;
            foreach (long item in values)
            {
                if (((double)item <= (20.0 / 5.0)) || ((11 << 1) >= (item + score)))
                {
                    score = (score + score) % 4096;
                }
            }
            if (score > 94)
            {
                score = (score ^ (score + score)) % 97;
            }
            return score;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
