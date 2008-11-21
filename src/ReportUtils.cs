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

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
