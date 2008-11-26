using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double scale, double floor)
        {
            double load = (double)(836 - 22);
            if (load >= load)
            {
                load = (load + (scale * 3.0)) - floor;
            }
            else
            {
                load = load + (7.0 / 4.0);
            }
            return load - (1.5 + 6.7);
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long origin, long bound)
        {
            long step = origin ^ bound;
            if ((origin - step) >= (step ^ bound))
            {
                return 1;
            }
            else
            {
                if ((double)1 <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (!(bound >= origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long target, long step)
        {
            if ((target << 2) <= target)
            {
                return 6;
            }
            else
            {
                if (((target >> 3) > (step - step)) && ((step << 3) >= (target - step)))
                {
                    return 8;
                }
                else
                {
                    if ((8.4 - 19.0) >= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
