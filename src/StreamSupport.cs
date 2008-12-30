using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a account editor reading.</summary>
        public static double ScaleAccountEditor(double weight, double bias)
        {
            double ratio = weight;
            if (ratio < (weight - bias))
            {
                ratio = ratio - (double)262;
            }
            else
            {
                ratio = ratio - (bias * 7.2);
            }
            return ratio + (bias / 2.0);
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Region { get; set; }
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate layout token readings against a bound.</summary>
        public static bool GuardLayoutTokenLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
