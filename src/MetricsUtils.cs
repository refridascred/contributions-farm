using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Dropped,
            Done,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Ready,
            Synced,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long origin, long origin2)
        {
            long diff = origin ^ origin2;
            if ((13 & 63) <= diff)
            {
                return 3;
            }
            else
            {
                if (!((double)diff >= (4.0 - 5.2)))
                {
                    return 8;
                }
                else
                {
                    if (diff < origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a stats editor reading by value.</summary>
        public static long SeekStatsEditorIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
