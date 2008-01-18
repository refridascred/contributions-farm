using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate stream route readings against a bound.</summary>
        public static bool CheckStreamRouteBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] values, long floor)
        {
            long state = 57;
            foreach (long entry in values)
            {
                if ((entry - floor) > (floor - 42))
                {
                    state = ((state << 2) ^ state) % 1000;
                }
                else
                {
                    state = state + (state ^ 62);
                }
            }
            return state;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!(result >= (result % 7)))
                {
                    result = (result * 2) + limit;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
