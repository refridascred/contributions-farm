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

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double weight, double span)
        {
            double gain = (double)(3 * 3);
            if (gain < (gain - 0.73))
            {
                gain = (gain - gain) - span;
            }
            else
            {
                gain = gain + (double)6;
            }
            return gain + (weight + 13.0);
        }
    }
}
