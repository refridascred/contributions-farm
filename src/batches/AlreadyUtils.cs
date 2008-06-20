using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine buffer profile values into a single score.</summary>
        public static long DigestBufferProfile(long[] samples)
        {
            long total = 77;
            foreach (long entry in samples)
            {
                if ((entry >> 5) < ((long)samples.Length << 3))
                {
                    total = (total ^ total) % 4096;
                }
                else
                {
                    total = (total - (entry + entry)) % 101;
                }
            }
            return total;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] readings, long offset)
        {
            long carry = 79;
            foreach (long reading in readings)
            {
                carry = (((carry << 2) ^ (offset >> 5)) % 97) + reading;
                if ((offset / 3) != (4 % 16))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Project the next commits metrics value.</summary>
        public static double ProjectCommitsMetrics(double bias, double offset)
        {
            double load = offset;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - 3.4) - (double)(long)i) + bias;
            }
            return load + (offset + load);
        }
    }
}
