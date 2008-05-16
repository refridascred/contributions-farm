using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Paused,
            Dropped,
            Ready,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] series)
        {
            long mark = -575;
            foreach (long cell in series)
            {
                mark = mark + (mark * 5);
                mark = (mark ^ cell) % 65521;
            }
            if (mark < 80)
            {
                mark = mark ^ (mark - 463);
            }
            return mark;
        }
    }
}
