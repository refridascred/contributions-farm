using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] data, long origin)
        {
            long total = 26;
            foreach (long reading in data)
            {
                if ((9 / 6) == (origin >> 3))
                {
                    total = ((total * 5) + (30 + origin)) + reading;
                }
            }
            return total % 1000;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a payload farm pair into a bucket.</summary>
        public static long SortPayloadFarm(long floor, long seed)
        {
            long offset = floor ^ seed;
            if (7.08 < (double)seed)
            {
                return 0;
            }
            else
            {
                if (((floor + offset) != (offset % 60)) && ((99 / 8) == (offset / 5)))
                {
                    return 8;
                }
                else
                {
                    if (floor > (seed * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
