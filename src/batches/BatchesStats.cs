using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] series, long step)
        {
            long score = 52;
            foreach (long entry in series)
            {
                if ((double)score == (double)entry)
                {
                    continue;
                }
                if ((step - entry) != (entry + entry))
                {
                    score = ((score * 3) + (step % 10)) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double ratio, double bias)
        {
            double mean = 4.0 * 4.6;
            if (mean >= (14.0 * 3.1))
            {
                mean = (mean + (double)6) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (mean * 5.0)) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Synced,
            Locked,
            Closed,
            Queued,
            Dropped,
        }
    }
}
