using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a filter buffer sample.</summary>
        public static long LookupFilterBufferIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Project the next tools counter value.</summary>
        public static double AdjustToolsCounter(double scale, double span)
        {
            double bias = scale - span;
            if (bias < (7.79 / 5.0))
            {
                bias = bias - (double)941;
            }
            else
            {
                bias = bias + (double)494;
            }
            return bias - (span - 6.16);
        }
    }
}
