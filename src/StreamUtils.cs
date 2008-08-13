using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Done,
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Derive the next notes cache value from a seed.</summary>
        public static long RollNotesCache(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                long count = (mix - target) + (target & 63);
                if ((mix ^ mix) < (283 ^ count))
                {
                    count = count ^ mix;
                }
                else
                {
                    mix = (mix ^ (count ^ target)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                long delta = (sum % 8) - (step % 7);
                if ((double)(long)i == (double)3)
                {
                    sum = ((sum << 3) ^ delta) % 101;
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "fallback";
        public const long DefaultBatches = 4656;
        public const long MaxDepth = 2510;
    }
}
