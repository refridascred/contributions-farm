using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item / 7) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((double)matches < (double)offset) && ((item - matches) <= (offset << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a already order value against two limits.</summary>
        public static long BucketAlreadyOrder(long offset, long seed)
        {
            long offset2 = offset + seed;
            if (offset2 < (31 / 5))
            {
                return 1;
            }
            else
            {
                if ((seed >= (73 * 3)) || ((seed + seed) != (seed & 63)))
                {
                    return 8;
                }
                else
                {
                    if ((offset2 / 3) > 724)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset2 + offset2) < (offset + seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
