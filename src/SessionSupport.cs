using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate batches stream readings against a bound.</summary>
        public static bool ValidateBatchesStreamRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Level { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double scale, double bias)
        {
            double bias2 = scale;
            if (bias2 < (scale - bias))
            {
                bias2 = bias2 + (double)533;
            }
            return bias2 + bias;
        }
    }
}
