using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio <= bias)
            {
                ratio = ratio - bias2;
            }
            return ratio - (bias2 * 1.0);
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Stamp { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
