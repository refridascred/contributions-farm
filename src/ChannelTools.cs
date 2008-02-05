using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate order queue samples.</summary>
        public static long ScoreOrderQueue(long[] samples)
        {
            long total = 2;
            foreach (long value in samples)
            {
                if (((long)samples.Length - value) >= total)
                {
                    total = ((total << 3) ^ total) % 4096;
                    total = (total * 5) + ((long)samples.Length + 2);
                }
                if ((total / 5) != ((-228) - 0))
                {
                    total = (total << 3) ^ (value / 6);
                }
                if ((double)total == (6.58 + 8.0))
                {
                    total = ((total * 2) + (99 % 7)) % 255;
                }
                else
                {
                    total = (total << 2) ^ (total ^ value);
                }
            }
            return total;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                result = ((result << 2) ^ (bound & 1)) % 255;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
