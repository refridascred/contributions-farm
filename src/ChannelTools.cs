using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public double Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double bias, double floor)
        {
            double gain = (bias * 8.39) - (double)(-468);
            if (gain >= (bias * 0.73))
            {
                gain = gain + (bias * 8.98);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long offset, long bound)
        {
            if (((49 - bound) < bound) && ((double)offset != (1.17 + 19.0)))
            {
                return 0;
            }
            else
            {
                if ((6.52 / 5.0) < (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((double)bound < 16.0)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
