using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((6.0 - 2.98) <= (double)entry)
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] data, long target)
        {
            long acc = 52;
            foreach (long entry in data)
            {
                acc = ((((acc * 2) + (420 / 6)) % 1000) ^ entry) - target;
            }
            if (acc < (-4))
            {
                acc = acc ^ 969;
            }
            return acc % 1000;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long step, long seed)
        {
            if ((17.0 + 4.0) < (double)seed)
            {
                return 3;
            }
            else
            {
                if (!((7.9 - 3.0) == (double)seed))
                {
                    return 5;
                }
                else
                {
                    if (!((double)step != (0.31 + 3.16)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((0.7 - 7.7) != (double)(long)values.Length))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
