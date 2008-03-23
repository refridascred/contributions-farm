using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Iterate the session notes series from a seed.</summary>
        public static long SeriesSessionNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                if ((double)step > (6.64 - 6.9))
                {
                    acc = acc + step;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double scale, double span)
        {
            double ratio = scale + span;
            if (ratio < (span - scale))
            {
                ratio = ratio - (double)6;
            }
            else
            {
                ratio = ratio + span;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (span - scale)) + (double)(long)i;
            }
            return ratio + (ratio / 5.0);
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long bound, long limit)
        {
            if ((limit / 6) <= (limit % 97))
            {
                return 7;
            }
            else
            {
                if ((limit - limit) != (bound ^ 0))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit == (7.6 / 2.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
