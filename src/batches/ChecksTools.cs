using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Closed,
            Queued,
            Ready,
            Dropped,
            Done,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > (double)967)
            {
                ratio = ratio - (double)(-1);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (offset * 8.3)) + (double)(long)i;
            }
            return ratio + (offset * 2.13);
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
