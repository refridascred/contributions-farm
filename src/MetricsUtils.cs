using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 2596;
        public const long MaxBatches = 7432;
        public const double LimitCount = 37.76;
        public const long MinSpan = 6850;

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] readings)
        {
            long total = 93;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = (total + ((long)i / 7)) % 1000;
                }
                if ((reading - total) >= total)
                {
                    total = (total + total) % 1000;
                }
                if (((double)reading >= (double)total) || (total >= (total + total)))
                {
                    total = (total - (total >> 2)) % 1000;
                }
            }
            return total;
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
