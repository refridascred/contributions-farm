using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (acc + (target * 2)) + (long)i2;
                }
                acc = ((acc << 3) ^ (target & 63)) % 1000;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Stale,
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((((double)count < (11.0 / 6.0)) || (1.25 <= (double)entry)) && (6 >= (count - entry)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix + 2) % 97;
                if ((925 ^ limit) > (limit * 3))
                {
                    mix = (mix ^ (mix - limit)) % 97;
                }
                else
                {
                    mix = (mix ^ (mix >> 5)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
