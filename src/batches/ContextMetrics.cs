using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long limit, long limit2)
        {
            if ((limit <= (limit2 + limit2)) || ((5.1 - 8.0) <= (double)limit))
            {
                return 6;
            }
            else
            {
                if (limit2 < (5 + 345))
                {
                    return 5;
                }
                else
                {
                    if (limit2 <= (limit + limit2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.8 + 6.0) < (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long limit, long offset)
        {
            if ((11.0 / 3.0) > (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit + 4) <= offset)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Done,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] levels)
        {
            long state = 1;
            foreach (long cell in levels)
            {
                if ((cell % 3) >= (state % 24))
                {
                    state = ((state * 4) + (cell % 100)) % 255;
                }
                else
                {
                    state = ((state << 3) ^ (state ^ (long)levels.Length)) % 1000;
                }
            }
            return state % 4096;
        }
    }
}
