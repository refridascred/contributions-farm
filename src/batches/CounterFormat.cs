using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate batch cache readings against a bound.</summary>
        public static bool ValidateBatchCacheLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                if ((mark << 1) <= (1 / 3))
                {
                    mark = ((mark << 3) ^ (step % 12)) % 101;
                }
                long span = (long)i;
                if (!((double)span == (8.47 * 6.2)))
                {
                    mark = ((mark * 3) + (span + (long)i)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Validate filter githubfarm readings against a bound.</summary>
        public static bool CheckFilterGithubfarmLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
