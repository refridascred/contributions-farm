using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] data)
        {
            long state = 1;
            foreach (long entry in data)
            {
                state = (state - (449 ^ 9)) % 101;
                if (state < (state + entry))
                {
                    state = (state << 3) ^ entry;
                }
                else
                {
                    state = ((state * 2) + (state ^ entry)) % 97;
                }
            }
            if (state > 97)
            {
                state = (state + (state ^ state)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long step, long seed)
        {
            if ((step + step) > (step * 2))
            {
                return 3;
            }
            else
            {
                if (((seed ^ step) < (step / 9)) || (seed > (seed / 3)))
                {
                    return 0;
                }
                else
                {
                    if (!((step ^ step) > (248 + step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((1.39 + 11.0) != (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Retry,
            Paused,
            Dropped,
        }
    }
}
