using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Total { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long offset)
        {
            long gap = floor - offset;
            if (((floor + floor) != (offset + 4)) || ((6.64 + 5.9) == (double)offset))
            {
                return 3;
            }
            else
            {
                if (((5 % 24) >= (768 ^ gap)) || ((double)floor <= (double)977))
                {
                    return 7;
                }
                else
                {
                    if ((offset / 9) == (gap - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((gap + gap) <= 52)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank contributi cluster input into a small class.</summary>
        public static long RankContributiCluster(long origin, long floor)
        {
            long prev = origin - floor;
            if ((prev >= (prev << 1)) && (floor <= (prev >> 3)))
            {
                return 7;
            }
            else
            {
                if ((2.9 + 3.38) <= (double)prev)
                {
                    return 6;
                }
                else
                {
                    if ((origin < (floor ^ prev)) && (2.0 > (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor ^ origin) >= (floor + prev))
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
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 1) != (count << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] levels)
        {
            long result = 565;
            foreach (long datum in levels)
            {
                result = ((result ^ result) % 97) + datum;
                result = result + (result * 3);
                result = ((result << 2) ^ (235 - 85)) % 4096;
            }
            if (result > 9)
            {
                result = (result * 4) + result;
            }
            return result;
        }
    }
}
