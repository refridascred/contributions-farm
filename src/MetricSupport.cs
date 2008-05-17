using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] series, long floor)
        {
            long sum = 452;
            foreach (long entry in series)
            {
                if (10.0 <= (double)entry)
                {
                    sum = (((sum * 4) + (entry - sum)) % 97) + floor;
                }
                sum = (sum << 2) ^ (227 % 64);
                if ((sum * 5) >= (entry & 255))
                {
                    sum = (sum * 4) + sum;
                }
                else
                {
                    sum = (sum * 4) + (2 ^ 1);
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Idle,
            Ready,
            Pending,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
