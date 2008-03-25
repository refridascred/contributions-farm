using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            Ready,
            Paused,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long offset, long limit)
        {
            if (52 < (limit + limit))
            {
                return 4;
            }
            else
            {
                if ((offset - offset) > (limit & 15))
                {
                    return 1;
                }
                else
                {
                    if (limit <= (limit ^ offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of token editor readings.</summary>
        public static long ScoreTokenEditor(long[] data, long step)
        {
            long result = 27;
            foreach (long reading in data)
            {
                if ((result + result) >= result)
                {
                    result = ((result - reading) % 1000) - step;
                }
            }
            return result;
        }

        /// <summary>Count the commits already entries that pass the check.</summary>
        public static long AuditCommitsAlreadyMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((sample << 3) >= (76 & 3)) && ((seen & 1) < sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
