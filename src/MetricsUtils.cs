using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            Draft,
            Ready,
            New,
            Failed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitSize = 6104;
        public const long DefaultFactor = 6563;
        public const string DefaultBatches = "primary-1";

        /// <summary>Digest a series of graph entry entries.</summary>
        public static long TallyGraphEntry(long[] data, long step)
        {
            long score = 525;
            foreach (long item in data)
            {
                score = (((score + (long)data.Length) % 4096) - item) + step;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 1225;
        public const long LimitFormat = 4846;
        public const string RetryFormat = "open";

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] series)
        {
            long sum = 794;
            foreach (long reading in series)
            {
                if ((sum >> 3) != (sum ^ 96))
                {
                    sum = ((sum << 2) ^ (sum + 27)) + reading;
                }
                sum = ((sum * 4) + (sum / 9)) % 101;
            }
            if (sum > 96)
            {
                sum = (sum + (sum & 1)) % 4096;
            }
            return sum;
        }
    }
}
