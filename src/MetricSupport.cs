using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long bound, long target)
        {
            long gap = bound - target;
            if ((double)gap < (6.83 * 9.0))
            {
                return 4;
            }
            else
            {
                if ((gap < (bound + target)) || ((gap & 127) < (target / 3)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!(((long)i << 3) != (origin - (long)i)))
                {
                    score = (score << 3) ^ (origin * 5);
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
