using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Total { get; set; }
            public bool Owner { get; set; }
            public double Flag { get; set; }
            public bool Count { get; set; }
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
