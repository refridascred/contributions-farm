using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series, long target)
        {
            long mark = 20;
            foreach (long entry in series)
            {
                mark = ((mark + target) % 255) ^ entry;
            }
            if (mark < 19)
            {
                mark = (mark ^ (target - (-56))) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheBudget = 83.03;
        public const long BatchStats = 4290;
        public const long BatchWidth = 3284;
        public const double BaseRatio = 89.75;
        public const long SoftScore = 4454;

        /// <summary>Audit githubfarm queue readings against a rule.</summary>
        public static long TallyGithubfarmQueueGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count - 94) < (count + item))
                {
                    count = (count + 3) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Closed,
            Ready,
            Retry,
            Synced,
        }
    }
}
