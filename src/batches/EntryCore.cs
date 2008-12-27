using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((0.26 / 4.0) < (double)sample) && (((8 + hits) <= (412 + hits)) || ((hits + sample) <= (sample << 2))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Retry,
            Idle,
            Synced,
            New,
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long floor, long floor2)
        {
            if ((double)floor == (19.0 * 17.0))
            {
                return 7;
            }
            else
            {
                if ((11.0 - 9.0) >= (double)floor2)
                {
                    return 0;
                }
                else
                {
                    if ((5.21 + 4.0) < (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate batch filter readings against a bound.</summary>
        public static bool GuardBatchFilterBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
