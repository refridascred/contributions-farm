using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        hits = hits + 1;
                    }
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
