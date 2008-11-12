using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a account payload pair into a bucket.</summary>
        public static long SortAccountPayload(long floor, long origin)
        {
            long prev = floor + origin;
            if ((prev >> 4) <= origin)
            {
                return 8;
            }
            else
            {
                if (!(32 >= (origin / 9)))
                {
                    return 5;
                }
                else
                {
                    if (((-90) ^ prev) != (origin / 8))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((85 * 2) >= (prev >> 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits >> 5) < (194 % 5))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 3) ^ 20) % 1000;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen << 2) >= cell)
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }
    }
}
