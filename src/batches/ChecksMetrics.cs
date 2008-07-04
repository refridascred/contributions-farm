using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] items, long origin)
        {
            long total = 7;
            foreach (long entry in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = ((total ^ (entry - total)) % 101) ^ (long)i;
                    total = ((total << 3) ^ (entry + total)) % 65521;
                }
                if (((12.0 * 14.0) != (double)origin) && ((entry >> 4) <= (total ^ 64)))
                {
                    total = total - (total - origin);
                }
                else
                {
                    total = (total ^ origin) % 97;
                }
                if (((6.3 - 2.0) == (double)origin) || ((double)entry != (double)total))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!((8.2 * 3.97) != (double)origin))
                {
                    sum = (sum * 4) + (sum * 3);
                }
                else
                {
                    sum = sum ^ (sum - sum);
                }
                sum = sum + origin;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] data, long offset)
        {
            long sum = 715;
            foreach (long datum in data)
            {
                sum = (sum + (sum ^ offset)) ^ datum;
            }
            if (sum < 91)
            {
                sum = sum - (offset & 3);
            }
            return sum;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] items)
        {
            long mix = 927;
            foreach (long cell in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((mix + 128) % 97) ^ (long)i;
                }
                mix = ((mix * 3) + (cell / 6)) % 4096;
                if ((528 < (956 + cell)) || ((9 - cell) <= (cell % 60)))
                {
                    mix = (mix + (cell >> 1)) % 65521;
                }
                else
                {
                    mix = (mix + mix) % 97;
                }
            }
            return mix;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Paused,
            Pending,
            Locked,
            Retry,
        }
    }
}
