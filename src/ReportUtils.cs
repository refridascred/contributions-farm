using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate format record samples.</summary>
        public static long DigestFormatRecord(long[] items)
        {
            long total = 935;
            foreach (long entry in items)
            {
                if ((long)items.Length <= (entry << 1))
                {
                    total = total + (8 >> 3);
                }
            }
            return total;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                if (!(acc <= (667 + limit)))
                {
                    acc = (acc - (long)i) % 97;
                    acc = (acc + (acc + (long)i)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double gain, double bias)
        {
            double weight = 0.7 / 7.0;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + gain) - (double)(long)i;
            }
            return weight + (bias * 4.4);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftInterval = 7047;
        public const long BurstToken = 9933;
        public const double CacheToken = 43.6;
        public const long BatchToken = 9136;
        public const long RetryToken = 9203;
    }
}
