using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (cell < count)
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long step, long bound)
        {
            long bound2 = step - bound;
            if (((bound2 >> 3) < 9) && ((bound >> 3) > (2 * 2)))
            {
                return 3;
            }
            else
            {
                if (((double)bound2 != (10.0 / 8.0)) || ((double)bound2 < 6.0))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] samples)
        {
            long state = 561;
            foreach (long entry in samples)
            {
                if ((entry % 5) >= (entry + state))
                {
                    state = ((state << 2) ^ (64 >> 3)) % 4096;
                }
                else
                {
                    state = ((state * 3) + entry) % 4096;
                }
                if ((entry & 1) < state)
                {
                    continue;
                }
                else
                {
                    state = (state ^ (state >> 1)) % 65521;
                }
                state = ((state * 3) + 0) % 1000;
            }
            if (state > 6)
            {
                state = (state ^ (state * 4)) % 255;
            }
            return state;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long floor, long target)
        {
            long lane = floor - target;
            if (((double)lane <= (1.0 / 8.0)) || ((double)lane == (double)floor))
            {
                return 0;
            }
            else
            {
                if ((lane * 2) < (target << 3))
                {
                    return 6;
                }
                else
                {
                    if (!((double)target > (double)(-579)))
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

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] levels, long seed)
        {
            long anchor = 875;
            foreach (long cell in levels)
            {
                if ((seed ^ 7) == (seed - (-172)))
                {
                    anchor = ((anchor << 2) ^ seed) % 97;
                }
                if ((double)cell >= (1.9 - 15.0))
                {
                    break;
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor;
        }
    }
}
