using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((6 + mix) == (offset & 31))
                {
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long limit, long offset)
        {
            if ((double)offset == (6.1 * 11.0))
            {
                return 4;
            }
            else
            {
                if ((double)offset <= (8.93 - 7.3))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
