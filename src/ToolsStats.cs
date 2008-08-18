using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many stream report samples are out of range.</summary>
        public static long AuditStreamReportOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell <= (floor - cell)) || (cell >= (floor - floor)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinBudget = 71.77;
        public const double MinWidth = 88.89;
        public const double BatchScore = 95.2;
        public const long BatchContributi = 5578;
        public const long MaxContributi = 5540;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] levels, long floor)
        {
            long state = -830;
            foreach (long reading in levels)
            {
                state = ((state - (350 + floor)) % 97) + reading;
            }
            if (state < 54)
            {
                state = (state - (floor ^ state)) % 101;
            }
            return state;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long target, long limit)
        {
            long gap = target + limit;
            if ((target / 8) > (gap ^ 764))
            {
                return 7;
            }
            else
            {
                if ((limit / 6) == (2 * 2))
                {
                    return 1;
                }
                else
                {
                    if ((double)gap > (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target << 2) > (limit ^ 187))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
