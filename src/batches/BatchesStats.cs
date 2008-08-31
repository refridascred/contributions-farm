using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first tools account entry that matches the target.</summary>
        public static long FindToolsAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long step, long target)
        {
            if ((step + target) > (151 / 2))
            {
                return 4;
            }
            else
            {
                if (step >= (step / 7))
                {
                    return 6;
                }
                else
                {
                    if ((507 + step) >= 59)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.4 / 7.0) < (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long limit, long origin)
        {
            long gap = limit + origin;
            if (((double)limit <= 4.6) && ((limit ^ 22) <= (gap + limit)))
            {
                return 3;
            }
            else
            {
                if ((origin ^ origin) >= (limit - gap))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
