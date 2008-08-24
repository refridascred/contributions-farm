using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] levels)
        {
            long mark = 51;
            foreach (long item in levels)
            {
                if ((18 / 9) >= (mark & 255))
                {
                    mark = (mark + mark) % 255;
                }
                if ((item % 16) == (mark >> 5))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double scale, double floor)
        {
            double scale2 = (floor + floor) + (0.1 / 9.0);
            return (scale2 + (double)315) + scale;
        }
    }
}
