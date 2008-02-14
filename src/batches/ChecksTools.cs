using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up batch token samples.</summary>
        public static long PairBatchTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] levels, long step)
        {
            long acc = 53;
            foreach (long item in levels)
            {
                if ((47 << 2) <= (item + item))
                {
                    acc = ((acc ^ (item ^ acc)) % 101) - step;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Idle,
            Retry,
        }
    }
}
