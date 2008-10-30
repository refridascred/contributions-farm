using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next account session value from a seed.</summary>
        public static long IterateAccountSession(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry * 4) + carry;
                if ((target ^ target) >= (target * 4))
                {
                    continue;
                }
                carry = (carry - ((long)i & 63)) % 4096;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Locked,
            Queued,
            Stale,
            Draft,
            New,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                if ((20.0 / 6.0) >= (double)(long)i)
                {
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Queued,
            Closed,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] items, long seed)
        {
            long score = 56;
            foreach (long entry in items)
            {
                score = ((((score * 5) + score) % 1000) - entry) - seed;
            }
            return score;
        }
    }
}
