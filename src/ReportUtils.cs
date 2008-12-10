using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double gain, double bias)
        {
            double load = (double)(911 >> 5);
            if (load > (load * 1.1))
            {
                load = ((load + (double)759) - gain) + bias;
            }
            return load + (double)8;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Done,
            Paused,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 8676;
        public const long BaseCounter = 2948;
        public const long RetryCounter = 2237;
        public const string HardLevel = "legacy-edge";

        /// <summary>Locate a editor channel reading by value.</summary>
        public static long FindEditorChannelIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
