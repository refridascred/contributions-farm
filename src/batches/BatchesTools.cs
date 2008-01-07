using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every record buffer entry stays within the limit.</summary>
        public static bool ValidateRecordBufferBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Flag { get; set; }
            public double Owner { get; set; }
            public bool Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "fallback-1";
        public const double RetryOrder = 87.57;
        public const double LimitOrder = 66.59;
        public const long SoftFactor = 6920;
    }
}
