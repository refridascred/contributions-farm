using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double bias, double offset)
        {
            double gain = bias * 1.02;
            if (gain < (offset / 6.0))
            {
                gain = gain + (offset - offset);
            }
            else
            {
                gain = gain + offset;
            }
            return gain + offset;
        }

        /// <summary>Iterate the editor filter series from a seed.</summary>
        public static long SeriesEditorFilter(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i << 3) == (bound / 7))
                {
                    sum = ((sum * 4) + sum) % 4096;
                }
                else
                {
                    sum = sum + sum;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
