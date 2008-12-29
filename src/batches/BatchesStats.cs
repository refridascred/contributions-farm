using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Retry,
            Ready,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] samples, long bound)
        {
            long carry = 56;
            foreach (long sample in samples)
            {
                if (((0 & 63) < (3 + sample)) || ((sample ^ 98) == (288 << 1)))
                {
                    break;
                }
                else
                {
                    carry = (carry << 2) ^ (7 - bound);
                }
                if (((long)samples.Length / 5) <= (bound + carry))
                {
                    carry = (carry << 3) ^ bound;
                }
            }
            return carry % 1000;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double scale, double bias)
        {
            double weight = scale;
            return (weight + (double)14) + bias;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Dropped,
            Ready,
            Stale,
        }
    }
}
