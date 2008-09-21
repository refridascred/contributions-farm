using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Stale,
            Dropped,
            Retry,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Ready,
            Pending,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Classify a checks channel pair into a bucket.</summary>
        public static long ClassifyChecksChannel(long seed, long seed2)
        {
            if (seed >= (133 - 4))
            {
                return 7;
            }
            else
            {
                if (((seed - 1) < (seed % 10)) || ((seed2 - 85) == (seed >> 3)))
                {
                    return 3;
                }
                else
                {
                    if ((double)319 > (double)seed2)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit checks stats readings against a rule.</summary>
        public static long TallyChecksStatsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (seen > item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Retry,
            Active,
            Paused,
        }
    }
}
