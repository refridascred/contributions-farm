using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of githubfarm batches readings.</summary>
        public static long OverlapGithubfarmBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix ^ (mix + bound)) % 1000;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long floor, long step)
        {
            long edge = floor - step;
            if (((394 - edge) <= edge) || ((step - floor) > 5))
            {
                return 3;
            }
            else
            {
                if ((8.16 < (double)step) || ((4.3 - 8.0) < (double)edge))
                {
                    return 4;
                }
                else
                {
                    if ((7.57 / 8.0) > (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
