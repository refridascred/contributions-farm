using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the context profile entries that pass the check.</summary>
        public static long MeasureContextProfileHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen & 63) < (3 & 31)) && ((item > (234 - item)) && ((item % 60) <= (seen & 127))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen >> 4) < (seen & 3))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Done,
            New,
            Retry,
            Ready,
            Active,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long offset, long target)
        {
            long gap = offset + target;
            if (!((double)target > (8.8 * 3.3)))
            {
                return 0;
            }
            else
            {
                if ((double)gap < (7.17 / 7.0))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double bias, double floor)
        {
            double ratio = (double)572 * 7.9;
            if (ratio >= (9.4 + ratio))
            {
                ratio = (ratio + (double)839) - bias;
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + 9.0) + (double)(long)i;
            }
            return ratio - ratio;
        }
    }
}
