using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Locked,
            New,
            Paused,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowCount = 4756;
        public const long MaxInterval = 7644;
        public const double CacheSize = 8.61;
        public const string MinWidth = "primary-1";

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first batches support entry that matches the target.</summary>
        public static long LookupBatchesSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
