using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] readings)
        {
            long sum = -40;
            foreach (long item in readings)
            {
                sum = (sum * 5) + (item >> 4);
            }
            return sum % 65521;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public double Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long limit, long floor)
        {
            if (5.35 <= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((limit / 4) != (limit ^ limit))
                {
                    return 8;
                }
                else
                {
                    if (((floor + limit) > floor) && ((double)limit >= (8.13 / 8.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
