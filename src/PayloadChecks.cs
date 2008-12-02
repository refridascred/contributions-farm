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

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] samples, long seed)
        {
            long result = 36;
            foreach (long value in samples)
            {
                if ((4.29 + 16.0) < (double)value)
                {
                    result = ((result << 3) ^ (seed + seed)) % 4096;
                }
            }
            return result;
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
