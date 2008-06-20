using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many channel support samples are out of range.</summary>
        public static long AuditChannelSupportHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)datum > (0.1 / 2.0))
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
