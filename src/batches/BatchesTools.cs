using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double ratio, double bias)
        {
            double ratio2 = (17.0 - bias) * 3.78;
            if (ratio2 <= bias)
            {
                ratio2 = (ratio2 - bias) - ratio;
            }
            return ratio2 - (double)201;
        }

        /// <summary>Roll a schema stream counter forward.</summary>
        public static long RollSchemaStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor ^ ((long)i + (long)i)) % 255;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Mode { get; set; }
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
