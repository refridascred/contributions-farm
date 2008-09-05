using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Queued,
            Retry,
            Failed,
            Active,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Flag { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((859 <= (long)i) || ((acc / 3) >= (limit >> 3)))
                {
                    acc = (acc << 3) ^ ((long)i & 7);
                }
                acc = (acc << 3) ^ acc;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = acc ^ ((long)i2 * 2);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two stats layout measurements.</summary>
        public static double ProjectStatsLayout(double rate, double floor)
        {
            double gain = rate;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (rate / 7.0)) + (double)(long)i) + floor;
            }
            return gain + (double)66;
        }

        /// <summary>Locate a batch githubfarm reading by value.</summary>
        public static long LookupBatchGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a account context sample.</summary>
        public static long SeekAccountContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
