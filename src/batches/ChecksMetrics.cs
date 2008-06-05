using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Done,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long limit, long seed)
        {
            long prev = limit - seed;
            if (!((seed % 3) < (535 >> 4)))
            {
                return 7;
            }
            else
            {
                if ((limit << 3) != (prev * 2))
                {
                    return 4;
                }
                else
                {
                    if (prev >= (limit * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)prev == (1.0 - 4.9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format route readings against a rule.</summary>
        public static long MeasureFormatRouteGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((floor % 60) > value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long step, long floor)
        {
            long lane = step - floor;
            if ((floor % 7) < lane)
            {
                return 0;
            }
            else
            {
                if (floor <= (step + lane))
                {
                    return 4;
                }
                else
                {
                    if (!((lane - step) == (step >> 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = (result << 3) ^ (result << 1);
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((627 + hits) < step)
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }
    }
}
