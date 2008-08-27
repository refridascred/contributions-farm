using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = carry ^ (32 % 16);
                carry = (carry << 2) ^ carry;
                carry = (carry - (seed + (long)i)) % 1000;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first route channel entry that matches the target.</summary>
        public static long LocateRouteChannelIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Active,
            New,
            Paused,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Idle,
            Retry,
            Failed,
            Synced,
            Stale,
        }
    }
}
