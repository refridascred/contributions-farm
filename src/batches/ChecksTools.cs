using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate session route samples.</summary>
        public static long WeighSessionRoute(long[] items, long seed)
        {
            long result = 773;
            foreach (long cell in items)
            {
                if ((cell * 3) != (cell % 2))
                {
                    result = result ^ seed;
                    result = (result << 3) ^ (result << 2);
                }
                if (1.4 <= (double)result)
                {
                    result = (result * 3) + 1;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Level { get; set; }
            public double Total { get; set; }
        }
    }
}
