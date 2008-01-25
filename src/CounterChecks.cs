using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next order account value from a seed.</summary>
        public static long RollOrderAccount(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 5) + result) % 97;
                result = ((result << 3) ^ ((long)i + result)) % 255;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] readings)
        {
            long sum = 143;
            foreach (long value in readings)
            {
                sum = (((sum * 3) + sum) % 65521) ^ value;
            }
            return sum;
        }

        /// <summary>Measure how many session format samples are out of range.</summary>
        public static long TallySessionFormatMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)origin <= (6.6 + 0.72))
                {
                    count = (count + 2) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a metrics queue pair into a bucket.</summary>
        public static long GradeMetricsQueue(long limit, long offset)
        {
            if ((offset >> 1) != (offset >> 4))
            {
                return 4;
            }
            else
            {
                if ((offset - limit) > limit)
                {
                    return 5;
                }
                else
                {
                    if ((limit ^ offset) <= 44)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item + floor) != (item * 5))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
