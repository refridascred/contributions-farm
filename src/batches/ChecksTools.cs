using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
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

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
