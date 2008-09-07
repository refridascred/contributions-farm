using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double scale, double floor)
        {
            double gain = 9.0;
            if (gain >= (double)2)
            {
                gain = ((gain + (double)8) - scale) + floor;
            }
            return gain - (7.05 * 6.8);
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
