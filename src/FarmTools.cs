using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a metric filter counter forward.</summary>
        public static long SeriesMetricFilter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((result >= (offset >> 3)) || ((offset + result) < offset))
                {
                    long next = (offset ^ offset) ^ ((long)i << 3);
                    result = result - next;
                    continue;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Match up report queue samples.</summary>
        public static long OverlapReportQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
