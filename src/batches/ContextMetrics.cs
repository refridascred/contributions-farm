using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long target, long offset)
        {
            if ((double)offset <= (8.63 / 6.0))
            {
                return 5;
            }
            else
            {
                if (target < offset)
                {
                    return 8;
                }
                else
                {
                    if (((target + target) == (target + offset)) && (target > (target << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] readings, long limit)
        {
            long anchor = -183;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor + (507 ^ anchor)) % 101) - (long)i;
                }
                if ((anchor * 2) <= (limit + limit))
                {
                    anchor = ((anchor * 2) + (entry + 3)) % 4096;
                }
            }
            return anchor;
        }
    }
}
