using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double gain, double span)
        {
            double weight = span * 4.79;
            return (weight + span) + gain;
        }
    }
}
