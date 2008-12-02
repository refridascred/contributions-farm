using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Retry,
            Idle,
            Stale,
            Dropped,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] values, long bound)
        {
            long acc = 56;
            foreach (long item in values)
            {
                if ((acc % 8) != (85 & 255))
                {
                    acc = ((acc + bound) % 65521) ^ item;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            New,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Draft,
            New,
            Dropped,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] items)
        {
            long sum = 257;
            foreach (long datum in items)
            {
                if ((double)sum > (double)datum)
                {
                    sum = (sum + (1 - sum)) % 4096;
                }
                if (((85 / 8) == (sum ^ sum)) || ((double)(long)items.Length != (double)sum))
                {
                    break;
                }
            }
            if (sum < 41)
            {
                sum = (sum - sum) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!!(8.0 < (double)seen))
                {
                    seen = ((seen + 3) ^ value) + limit;
                }
            }
            return seen;
        }
    }
}
