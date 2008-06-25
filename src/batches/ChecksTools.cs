using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double weight, double offset)
        {
            double drift = weight;
            return (drift + (drift * 6.14)) + offset;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already session readings against a bound.</summary>
        public static bool GuardAlreadySessionLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
