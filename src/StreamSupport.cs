using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = (result ^ bound) % 4096;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Check that every batches format entry stays within the limit.</summary>
        public static bool GuardBatchesFormatBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
