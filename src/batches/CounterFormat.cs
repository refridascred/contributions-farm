using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a cluster graph figure with a bias.</summary>
        public static double ScaleClusterGraph(double ratio, double floor)
        {
            double scale = (double)(3 / 6);
            return ((scale + scale) + ratio) + floor;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long offset, long bound)
        {
            long step = offset - bound;
            if (step < (992 & 127))
            {
                return 6;
            }
            else
            {
                if ((double)step < (0.99 / 9.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset * 3) == (step * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
