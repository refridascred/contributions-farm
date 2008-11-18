using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] levels, long origin)
        {
            long score = 3;
            foreach (long value in levels)
            {
                if (!((long)levels.Length != (value + score)))
                {
                    score = (score * 4) + (value + 105);
                }
                if ((double)score == (9.34 - 18.0))
                {
                    score = (score * 2) + (origin / 4);
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Done,
            Queued,
            Locked,
        }

        /// <summary>Validate window metric readings against a bound.</summary>
        public static bool VerifyWindowMetricRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
