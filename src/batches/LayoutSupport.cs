using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next stats githubfarm value from a seed.</summary>
        public static long RollStatsGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (state + (limit / 6)) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] data)
        {
            long total = 8;
            foreach (long cell in data)
            {
                if (!((cell - total) >= total))
                {
                    total = total - (total & 63);
                }
            }
            return total;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] levels, long target)
        {
            long mix = 8;
            foreach (long cell in levels)
            {
                mix = (mix ^ (target + 361)) % 65521;
                if ((mix * 2) < (938 + cell))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
