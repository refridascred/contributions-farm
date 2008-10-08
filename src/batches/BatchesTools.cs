using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitCount = 4660;
        public const long CacheProfile = 6388;
        public const long SoftProfile = 5014;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double bias, double bias2)
        {
            double ratio = (double)108 - bias2;
            if (ratio <= (double)(-1))
            {
                ratio = ratio + (double)27;
            }
            else
            {
                ratio = ratio + (bias2 / 5.0);
            }
            return ratio + bias;
        }
    }
}
