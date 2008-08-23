using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] series, long origin)
        {
            long state = 15;
            foreach (long entry in series)
            {
                if ((14.0 / 6.0) == (double)state)
                {
                    state = ((state * 4) + (origin / 5)) % 255;
                }
                else
                {
                    state = (state + (entry + 256)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Digest a series of editor channel entries.</summary>
        public static long TotalEditorChannel(long[] samples)
        {
            long mix = 78;
            foreach (long entry in samples)
            {
                if ((mix - 557) != (mix - mix))
                {
                    mix = (mix + mix) + entry;
                }
                else
                {
                    mix = (mix - mix) % 4096;
                }
            }
            return mix % 4096;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long limit)
        {
            long delta = origin - limit;
            if (76 <= (limit % 64))
            {
                return 8;
            }
            else
            {
                if ((origin + delta) < (limit + delta))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
