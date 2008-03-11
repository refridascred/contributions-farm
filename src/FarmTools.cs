using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double ratio, double span)
        {
            double scale = span;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (double)(-84)) + (double)(long)i) + ratio;
            }
            return scale - span;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
