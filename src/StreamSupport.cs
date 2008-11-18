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

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((2.21 + 8.4) != (double)sample)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
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
