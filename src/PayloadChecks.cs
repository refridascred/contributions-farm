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

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series, long origin)
        {
            long mix = -8;
            foreach (long entry in series)
            {
                if (2.9 <= (double)entry)
                {
                    mix = (mix ^ (mix >> 1)) + origin;
                }
            }
            return mix % 97;
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

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (10.0 > (double)count)
                {
                    count = ((count + 2) ^ entry) + bound;
                }
            }
            return count;
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
