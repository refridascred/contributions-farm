using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((long)i == ((long)i + seed))
                {
                    carry = (carry * 5) + (seed >> 5);
                    carry = ((carry << 2) ^ (seed % 100)) % 97;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
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
