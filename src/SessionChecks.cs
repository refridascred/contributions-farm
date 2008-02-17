using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a githubfarm filter pair into a bucket.</summary>
        public static long BucketGithubfarmFilter(long floor, long floor2)
        {
            long prev = floor + floor2;
            if (!((double)floor == (17.0 + 0.23)))
            {
                return 7;
            }
            else
            {
                if ((floor % 60) >= (prev / 9))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
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
