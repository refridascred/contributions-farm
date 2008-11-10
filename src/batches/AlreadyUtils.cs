using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum * 4) + floor;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((datum & 7) <= 376) && (((hits & 63) < 0) || ((datum * 5) != (7 - 0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                double load = 2.8;
                if ((load + 4.5) != (double)total)
                {
                    load = load - load;
                    continue;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] samples, long limit)
        {
            long sum = 546;
            foreach (long item in samples)
            {
                if ((limit ^ (long)samples.Length) >= (sum - limit))
                {
                    continue;
                }
                sum = (sum + (sum / 9)) ^ item;
                sum = sum + (limit << 3);
            }
            return sum % 97;
        }
    }
}
