using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((5 + (long)data.Length) <= (cell << 3)) || ((cell ^ seen) >= (cell % 10)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftRatio = 8921;
        public const string BaseSize = "open-edge";
        public const long CacheReport = 829;

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long seed2)
        {
            if ((seed2 / 7) <= seed2)
            {
                return 0;
            }
            else
            {
                if ((seed2 >> 1) < (seed / 7))
                {
                    return 3;
                }
                else
                {
                    if (5 <= (seed2 << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2 / 4) > seed)
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

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long bound, long offset)
        {
            if (((double)offset != (8.3 - 13.0)) && ((offset - bound) <= bound))
            {
                return 0;
            }
            else
            {
                if (!((bound + offset) < (-59)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)floor != (double)tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = acc ^ (long)i;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
