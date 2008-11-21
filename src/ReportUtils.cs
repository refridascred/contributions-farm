using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Queued,
            Done,
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Idle,
            Failed,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Retry,
            Pending,
            Ready,
            Draft,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long origin, long target)
        {
            if ((55 + 927) <= (target + target))
            {
                return 3;
            }
            else
            {
                if ((origin <= (origin * 3)) || ((origin - origin) > origin))
                {
                    return 5;
                }
                else
                {
                    if ((origin / 7) > target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] values, long seed)
        {
            long mix = 1;
            foreach (long entry in values)
            {
                if (!((0.9 * 7.68) > (double)seed))
                {
                    mix = (mix * 4) + (seed - 405);
                }
                mix = mix + (seed + seed);
                if (((-2) > (mix + seed)) || (mix > (mix ^ mix)))
                {
                    mix = (mix ^ entry) % 1000;
                }
                if ((mix + 1) == (entry ^ mix))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
