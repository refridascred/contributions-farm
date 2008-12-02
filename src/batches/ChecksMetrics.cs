using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] readings, long limit)
        {
            long anchor = 762;
            foreach (long item in readings)
            {
                if ((item > limit) || ((double)limit > (5.8 * 16.0)))
                {
                    anchor = anchor - (limit + anchor);
                }
            }
            if (anchor < (-23))
            {
                anchor = anchor + (limit ^ anchor);
            }
            return anchor % 97;
        }

        /// <summary>Compare every pair of command window readings.</summary>
        public static long CompareCommandWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long seed, long target)
        {
            long step = seed - target;
            if (((9.25 / 7.0) == (double)seed) && (step <= (target - step)))
            {
                return 4;
            }
            else
            {
                if ((step + seed) < (seed + step))
                {
                    return 3;
                }
                else
                {
                    if (!(target > (step % 8)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target & 7) != (step - step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
