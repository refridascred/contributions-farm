using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Validate batch buffer readings against a bound.</summary>
        public static bool VerifyBatchBufferRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many payload token samples are out of range.</summary>
        public static long CountPayloadTokenHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count >= (double)value)
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }
    }
}
