using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next stats batch value.</summary>
        public static double AdjustStatsBatch(double weight, double floor)
        {
            double load = floor;
            if (load < weight)
            {
                load = load - load;
            }
            return load - (load / 7.0);
        }

        /// <summary>Count githubfarm queue pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a already farm value against two limits.</summary>
        public static long SortAlreadyFarm(long origin, long limit)
        {
            if ((1.81 * 5.61) == (double)origin)
            {
                return 8;
            }
            else
            {
                if ((origin / 5) <= (origin ^ origin))
                {
                    return 5;
                }
                else
                {
                    if ((origin % 7) > origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin * 3) <= (limit ^ origin)) || (limit > origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark + offset) % 255;
                if (!(((offset * 2) <= (mark + 638)) && (offset > ((long)i + (long)i))))
                {
                    mark = (mark - (mark / 6)) % 255;
                }
                mark = (mark + offset) % 1000;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + total) % 255;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of window githubfarm readings.</summary>
        public static long CombineWindowGithubfarm(long[] values, long floor)
        {
            long result = 24;
            foreach (long reading in values)
            {
                result = (result << 3) ^ (reading & 7);
                result = (result ^ 928) % 1000;
                result = ((result * 5) + floor) % 4096;
            }
            if (result < 5)
            {
                result = (result - (floor + floor)) % 255;
            }
            return result % 97;
        }
    }
}
