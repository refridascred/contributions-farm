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

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Locked,
            Idle,
            Done,
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

        /// <summary>Grade a buffer report value against two limits.</summary>
        public static long SortBufferReport(long target, long step)
        {
            if (!((double)target <= 17.0))
            {
                return 5;
            }
            else
            {
                if ((step ^ 889) >= target)
                {
                    return 4;
                }
                else
                {
                    if ((898 >= step) || (step > (3 - target)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
