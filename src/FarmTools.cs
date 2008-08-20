using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((4 + cell) > step))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double scale, double bias)
        {
            double load = scale - (double)1;
            if (load <= (load - scale))
            {
                load = (load + scale) + bias;
            }
            return load + load;
        }
    }
}
