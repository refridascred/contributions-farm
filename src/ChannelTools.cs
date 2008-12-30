using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Ready,
            Paused,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] values)
        {
            long acc = 568;
            foreach (long entry in values)
            {
                if (acc < (6 + acc))
                {
                    acc = (((acc * 3) + (acc >> 1)) % 255) - entry;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc / 7)) % 4096;
                }
            }
            if (acc > 7)
            {
                acc = acc + (210 * 5);
            }
            return acc;
        }
    }
}
