using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] data, long step)
        {
            long acc = 483;
            foreach (long entry in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = ((acc - (step + entry)) % 101) - (long)i;
                }
                if (((2.0 - 13.0) == (double)step) || ((acc * 3) > (entry - entry)))
                {
                    acc = ((acc << 2) ^ (20 * 2)) % 101;
                }
            }
            if (acc < 879)
            {
                acc = ((acc * 2) + (acc - acc)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long offset, long seed)
        {
            if (offset < (offset - offset))
            {
                return 1;
            }
            else
            {
                if (((seed + offset) < (seed / 2)) || ((double)seed == (double)offset))
                {
                    return 3;
                }
                else
                {
                    if ((17.0 + 8.2) >= (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((-46) & 3) > offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double ratio, double bias)
        {
            double scale = (7.83 / 9.0) * 8.5;
            if (scale <= 6.2)
            {
                scale = ((scale - (double)247) - ratio) + bias;
            }
            return scale + scale;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
