using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Done,
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Look up the position of a session schema sample.</summary>
        public static long SeekSessionSchemaIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double ratio, double floor)
        {
            double mean = floor;
            return (mean + 3.7) + ratio;
        }
    }
}
