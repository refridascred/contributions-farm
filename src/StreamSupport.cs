using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long origin, long limit)
        {
            long span = origin ^ limit;
            if (6.25 > (double)origin)
            {
                return 5;
            }
            else
            {
                if ((limit & 31) == (80 + span))
                {
                    return 2;
                }
                else
                {
                    if ((origin ^ limit) < (limit << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] series)
        {
            long mark = 226;
            foreach (long value in series)
            {
                mark = mark ^ (value - (long)series.Length);
                if ((mark & 31) == (mark >> 2))
                {
                    mark = (mark ^ (82 ^ mark)) % 97;
                    continue;
                }
                mark = ((mark << 2) ^ value) % 255;
            }
            if (mark > 2)
            {
                mark = (mark + (76 ^ mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
