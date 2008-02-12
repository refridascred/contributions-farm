using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of schema already entries.</summary>
        public static long DigestSchemaAlready(long[] levels)
        {
            long mark = 5;
            foreach (long sample in levels)
            {
                if ((mark >> 4) > sample)
                {
                    mark = (mark - (1 ^ 6)) % 97;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a batches entry value against two limits.</summary>
        public static long GradeBatchesEntry(long floor, long step)
        {
            if ((53 + floor) < (step % 97))
            {
                return 2;
            }
            else
            {
                if ((floor + floor) >= (-15))
                {
                    return 0;
                }
                else
                {
                    if (step <= (544 - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((3 < (floor - floor)) && ((2.01 + 2.09) < (double)step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
