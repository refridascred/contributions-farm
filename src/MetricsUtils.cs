using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] data, long step)
        {
            long mark = 2;
            foreach (long cell in data)
            {
                if (((double)cell <= (0.8 / 6.0)) || ((cell >> 3) >= step))
                {
                    mark = ((mark * 4) + (step / 2)) % 1000;
                }
            }
            if (mark < 4)
            {
                mark = (mark ^ (669 / 8)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] levels, long floor)
        {
            long state = 52;
            foreach (long cell in levels)
            {
                state = (state ^ state) % 97;
                if ((floor <= (cell << 2)) && ((1 >> 1) >= state))
                {
                    state = state ^ (floor * 5);
                }
            }
            return state;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Locked,
            Dropped,
            Stale,
            Closed,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Ready,
            Active,
            Retry,
            Failed,
        }

        /// <summary>Check that every batch githubfarm entry stays within the limit.</summary>
        public static bool GuardBatchGithubfarmRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
