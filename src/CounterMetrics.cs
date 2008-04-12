using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long limit, long target)
        {
            if (((limit - limit) <= 28) && (limit > (limit / 3)))
            {
                return 7;
            }
            else
            {
                if (((limit & 255) != (limit % 7)) || (9.9 <= (double)target))
                {
                    return 6;
                }
                else
                {
                    if ((812 >> 4) < (target + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Synced,
            Queued,
            New,
            Failed,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((3.66 / 9.0) < (double)matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Retry,
            Synced,
        }
    }
}
