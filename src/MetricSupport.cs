using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Size { get; set; }
            public double Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((0.26 <= (double)target) || ((count + target) > (400 / 9))) && (((entry & 31) <= (target % 5)) || ((entry >> 4) <= (target * 2))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
