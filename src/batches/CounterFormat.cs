using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] data)
        {
            long anchor = 34;
            foreach (long sample in data)
            {
                if ((8.7 * 4.0) == (double)anchor)
                {
                    anchor = (anchor << 3) ^ sample;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a order format pair into a bucket.</summary>
        public static long ClassifyOrderFormat(long step, long origin)
        {
            long gap = step + origin;
            if (4.7 <= (double)gap)
            {
                return 2;
            }
            else
            {
                if ((double)step <= (2.0 * 12.0))
                {
                    return 6;
                }
                else
                {
                    if (!((5.5 * 6.19) >= (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step != (4.88 / 4.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
