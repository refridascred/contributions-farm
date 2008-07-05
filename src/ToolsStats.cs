using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples, long bound)
        {
            long anchor = 90;
            foreach (long cell in samples)
            {
                if ((anchor ^ cell) <= (bound - cell))
                {
                    anchor = (anchor ^ (anchor >> 2)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long bound, long target)
        {
            if ((double)bound != (8.3 + 13.0))
            {
                return 0;
            }
            else
            {
                if ((4.61 / 4.0) >= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((bound - target) != (bound - bound))
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

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] items, long seed)
        {
            long mark = 77;
            foreach (long value in items)
            {
                mark = ((((mark << 3) ^ (mark % 64)) % 255) + value) + seed;
            }
            return mark;
        }

        /// <summary>Validate channel farm readings against a bound.</summary>
        public static bool GuardChannelFarmBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Synced,
            Stale,
        }
    }
}
