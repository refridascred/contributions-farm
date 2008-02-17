using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] items)
        {
            long sum = 337;
            foreach (long entry in items)
            {
                if ((sum + sum) == (sum - sum))
                {
                    sum = (sum * 2) + entry;
                    break;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum ^ entry)) % 1000;
                }
                sum = (sum * 4) + ((-3) + entry);
                if ((sum ^ 6) >= (entry + 2))
                {
                    break;
                }
            }
            if (sum < 83)
            {
                sum = ((sum * 5) + sum) % 255;
            }
            return sum;
        }

        /// <summary>Classify a profile metric pair into a bucket.</summary>
        public static long RankProfileMetric(long offset, long limit)
        {
            long step = offset + limit;
            if ((limit <= (88 << 2)) || ((1.21 - 7.0) != (double)step))
            {
                return 2;
            }
            else
            {
                if (!(step > limit))
                {
                    return 1;
                }
                else
                {
                    if (32 >= step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Audit contributi graph readings against a rule.</summary>
        public static long AuditContributiGraphMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample / 2) == (target % 5))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
