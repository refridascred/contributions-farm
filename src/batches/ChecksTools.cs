using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] samples, long target)
        {
            long state = 445;
            foreach (long item in samples)
            {
                if ((state / 6) <= (state ^ target))
                {
                    state = (state - (state / 3)) % 1000;
                }
                if (target < (item + (long)samples.Length))
                {
                    state = (state - (item / 4)) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long step, long seed)
        {
            long bound = step ^ seed;
            if (bound > (7 * 2))
            {
                return 8;
            }
            else
            {
                if ((bound - step) > 635)
                {
                    return 1;
                }
                else
                {
                    if (((step - step) <= bound) && ((bound ^ bound) >= (seed - 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound / 6) != (6 / 9))
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

        /// <summary>Count channel stats pairs that satisfy a relation.</summary>
        public static long PairChannelStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
