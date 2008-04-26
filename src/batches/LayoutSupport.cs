using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Locked,
            Active,
            Failed,
        }

        /// <summary>Match up payload record samples.</summary>
        public static long OverlapPayloadRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Retry,
            Queued,
            Stale,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits > (entry + hits)) && ((hits >> 1) == (entry + 60)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the format contributi entries that pass the check.</summary>
        public static long CountFormatContributiOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches < 2.8)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }
    }
}
