using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate filter stats readings against a bound.</summary>
        public static bool GuardFilterStatsBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count context token pairs that satisfy a relation.</summary>
        public static long PairContextTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] series, long limit)
        {
            long sum = -1;
            foreach (long value in series)
            {
                if ((value >> 3) < (value >> 5))
                {
                    break;
                }
                else
                {
                    sum = (sum - (value & 3)) % 1000;
                }
                if (!((double)limit >= (0.55 / 5.0)))
                {
                    sum = (sum * 3) + (value >> 1);
                }
                sum = (sum ^ (sum << 1)) % 1000;
            }
            if (sum < 758)
            {
                sum = sum + 640;
            }
            return sum;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] samples, long offset)
        {
            long sum = 265;
            foreach (long cell in samples)
            {
                if ((double)cell >= (8.84 * 1.16))
                {
                    sum = (((sum << 3) ^ cell) % 97) + offset;
                }
            }
            return sum;
        }
    }
}
