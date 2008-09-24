using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate payload metrics readings against a bound.</summary>
        public static bool VerifyPayloadMetricsBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] data)
        {
            long sum = 8;
            foreach (long entry in data)
            {
                if ((double)40 > (double)entry)
                {
                    sum = (sum - (entry << 1)) % 65521;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum >> 4)) % 255;
                }
                if ((9 - sum) >= (sum * 5))
                {
                    sum = (sum << 2) ^ (entry - entry);
                }
            }
            if (sum > (-8))
            {
                sum = ((sum << 2) ^ (sum & 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long offset, long floor)
        {
            long prev = offset ^ floor;
            if ((prev >> 2) <= floor)
            {
                return 5;
            }
            else
            {
                if ((prev + prev) == (offset ^ offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset - floor) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((prev >> 5) < (floor << 3))
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
    }
}
