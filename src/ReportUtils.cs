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

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] series)
        {
            long mark = 85;
            foreach (long reading in series)
            {
                if (((long)series.Length > 9) || (9 >= (mark - reading)))
                {
                    mark = mark ^ reading;
                }
                else
                {
                    mark = mark + (mark >> 5);
                }
            }
            if (mark > (-952))
            {
                mark = (mark + (mark << 2)) % 1000;
            }
            return mark;
        }
    }
}
