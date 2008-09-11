using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a checks window value against two limits.</summary>
        public static long ClassifyChecksWindow(long origin, long seed)
        {
            if (((double)537 >= (double)origin) && ((origin / 6) == (seed >> 2)))
            {
                return 5;
            }
            else
            {
                if (((origin / 5) > (879 + origin)) && ((9.3 * 0.7) == (double)origin))
                {
                    return 3;
                }
                else
                {
                    if (((origin - seed) != (0 - seed)) || ((6 + 156) < (origin - seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed + 226) != (seed / 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate checks batches readings against a bound.</summary>
        public static bool ValidateChecksBatchesRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] data)
        {
            long total = 330;
            foreach (long datum in data)
            {
                if (((datum * 4) >= (total & 255)) && ((datum + datum) >= (datum * 5)))
                {
                    total = (total + (datum - 287)) % 97;
                }
            }
            if (total < 46)
            {
                total = ((total << 3) ^ (total / 5)) % 97;
            }
            return total;
        }
    }
}
