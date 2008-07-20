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

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long limit)
        {
            long result = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((double)(long)i > (11.0 + 19.0))
                {
                    result = result ^ (result - 5);
                    result = (result - limit) % 1000;
                }
                result = ((result * 3) + (long)i) % 4093;
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
