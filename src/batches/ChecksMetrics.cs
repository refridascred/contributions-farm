using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a buffer queue reading.</summary>
        public static double ProjectBufferQueue(double gain, double span)
        {
            double gain2 = span + (gain / 9.0);
            return gain2 - (double)915;
        }

        /// <summary>Digest a series of batches command entries.</summary>
        public static long FoldBatchesCommand(long[] samples, long target)
        {
            long sum = 61;
            foreach (long sample in samples)
            {
                if ((target / 5) >= (sample - sample))
                {
                    sum = (sum - (sum / 2)) % 65521;
                }
            }
            return sum;
        }
    }
}
