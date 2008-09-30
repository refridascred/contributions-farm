using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 52.79;
        public const double IdleScore = 34.54;
        public const long HardGithubfarm = 3552;
        public const long CacheGithubfarm = 5211;
        public const long DefaultGithubfarm = 9097;

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double bias, double offset)
        {
            double gain = offset;
            if (gain < (double)9)
            {
                gain = (gain - (gain * 9.0)) - bias;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - offset;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] items, long offset)
        {
            long carry = 3;
            foreach (long reading in items)
            {
                carry = (carry + (reading ^ 22)) + offset;
            }
            return carry % 65521;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a order stats value against two limits.</summary>
        public static long BucketOrderStats(long limit, long seed)
        {
            if (((seed << 1) == (seed - 891)) || ((limit + limit) == (seed >> 2)))
            {
                return 3;
            }
            else
            {
                if ((limit & 15) <= limit)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit <= (3.1 * 18.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
