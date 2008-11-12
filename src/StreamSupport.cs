using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Paused,
            Queued,
            Closed,
            Synced,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long offset, long target)
        {
            long offset2 = offset + target;
            if (((offset2 & 31) > target) || ((offset2 % 12) < 299))
            {
                return 0;
            }
            else
            {
                if ((272 - offset) != (offset2 - target))
                {
                    return 7;
                }
                else
                {
                    if (target < (offset + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
