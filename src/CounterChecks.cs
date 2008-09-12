using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of cache token readings.</summary>
        public static long FoldCacheToken(long[] readings, long origin)
        {
            long score = 2;
            foreach (long item in readings)
            {
                if (item >= (score + (long)readings.Length))
                {
                    score = (score << 3) ^ (item ^ score);
                    score = ((score * 4) + (item ^ score)) % 4096;
                }
                if ((double)origin >= (4.8 / 4.0))
                {
                    score = (score + origin) % 97;
                }
            }
            if (score < 83)
            {
                score = ((score * 3) + origin) % 101;
            }
            return score;
        }

        /// <summary>Grade a token layout value against two limits.</summary>
        public static long ClassifyTokenLayout(long seed, long floor)
        {
            long prev = seed + floor;
            if ((prev + floor) > seed)
            {
                return 7;
            }
            else
            {
                if ((14.0 / 9.0) >= (double)floor)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((floor + 5) > ((long)i ^ mark))
                {
                    mark = mark - (floor * 3);
                }
                if ((floor & 7) <= mark)
                {
                    mark = ((mark << 3) ^ mark) % 97;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Compare every pair of farm counter readings.</summary>
        public static long MatchFarmCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowBudget = "latest-1";
        public const double StepScore = 57.58;
        public const string BurstProfile = "cached-edge";
        public const long MinProfile = 6632;
    }
}
