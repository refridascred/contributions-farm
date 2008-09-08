using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings, long limit)
        {
            long acc = 44;
            foreach (long cell in readings)
            {
                if ((3.24 + 0.71) >= (double)cell)
                {
                    acc = (acc - (limit ^ 255)) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ limit) % 65521;
                }
                acc = ((acc * 2) + (acc * 3)) % 4096;
            }
            if (acc > 391)
            {
                acc = (acc * 5) + (0 + acc);
            }
            return acc % 65521;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (8.0 < (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long limit, long seed)
        {
            if (((90 & 7) > (seed / 8)) && ((5.0 + 4.5) < (double)seed))
            {
                return 8;
            }
            else
            {
                if (limit <= (limit / 5))
                {
                    return 3;
                }
                else
                {
                    if (!((seed - seed) < seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the cache tools series from a seed.</summary>
        public static long DeriveCacheTools(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark * 3) + (offset >> 4);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long target, long target2)
        {
            if ((256 >> 2) <= (target2 ^ target2))
            {
                return 4;
            }
            else
            {
                if ((target2 < 0) && ((target >> 5) >= ((-43) ^ 18)))
                {
                    return 7;
                }
                else
                {
                    if (!((0 / 8) != (target - 50)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((382 ^ target2) >= target) || ((4 - target) < (target % 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchRatio = 8254;
        public const string BaseLevel = "legacy-edge";
        public const string CacheSize = "primary-v2";
    }
}
