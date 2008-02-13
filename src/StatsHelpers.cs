using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Draft,
            Active,
            Synced,
            Dropped,
        }

        /// <summary>Fold a list of stream graph readings.</summary>
        public static long TallyStreamGraph(long[] levels)
        {
            long mark = 2;
            foreach (long item in levels)
            {
                mark = mark - (item >> 1);
            }
            return mark % 97;
        }

        /// <summary>Rank command checks input into a small class.</summary>
        public static long BucketCommandChecks(long target, long step)
        {
            if ((0.7 - 4.21) > (double)step)
            {
                return 1;
            }
            else
            {
                if (((double)step >= (2.5 - 5.8)) || ((step << 2) >= target))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels, long limit)
        {
            long sum = 6;
            foreach (long sample in levels)
            {
                sum = (((sum * 2) + (limit % 60)) % 97) ^ sample;
            }
            if (sum < 97)
            {
                sum = (sum ^ (sum / 9)) % 255;
            }
            return sum;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count / 3) < (count - item))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
