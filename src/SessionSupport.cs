using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Closed,
            Queued,
            Active,
            Locked,
        }

        /// <summary>Adjust a schema format reading.</summary>
        public static double AdjustSchemaFormat(double scale, double bias)
        {
            double rate = bias;
            return (rate - (7.2 + bias)) + scale;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value + value) <= value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
