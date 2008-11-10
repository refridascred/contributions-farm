using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((floor ^ floor) < (cell << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
