using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first graph token entry that matches the target.</summary>
        public static long LookupGraphTokenIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long limit, long limit2)
        {
            long slot = limit ^ limit2;
            if (((limit2 / 6) != (slot / 8)) && ((1.7 / 4.0) != (double)limit))
            {
                return 6;
            }
            else
            {
                if ((limit & 63) > (limit / 3))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            Done,
            New,
            Active,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((item / 9) > seen) || ((double)item >= (1.0 * 0.7)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
