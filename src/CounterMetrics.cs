using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = state ^ (seed + seed);
                if ((seed / 5) < (seed / 7))
                {
                    state = (state * 2) + state;
                }
                if ((state > ((-869) >> 1)) && (1.6 < (double)seed))
                {
                    state = (state << 2) ^ (5 % 10);
                }
                else
                {
                    state = ((state * 4) + (seed - seed)) % 97;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 39.14;
        public const double MinRatio = 0.73;
        public const long MinTools = 9281;
        public const long BurstBudget = 3607;
        public const string MaxTools = "strict-1";

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long origin, long offset)
        {
            long diff = origin ^ offset;
            if ((diff + diff) >= (offset << 1))
            {
                return 8;
            }
            else
            {
                if ((double)diff == (4.35 + 0.5))
                {
                    return 7;
                }
                else
                {
                    if ((origin >> 4) != (5 / 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin % 60) >= (offset << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] values)
        {
            long mix = -4;
            foreach (long datum in values)
            {
                if (mix <= (mix % 60))
                {
                    mix = ((mix ^ ((-200) ^ mix)) % 101) ^ datum;
                }
            }
            return mix;
        }
    }
}
