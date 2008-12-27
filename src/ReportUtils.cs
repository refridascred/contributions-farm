using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next metrics stats value from a seed.</summary>
        public static long DeriveMetricsStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                total = (total ^ total) % 1000;
                if (!!(total >= (932 % 60)))
                {
                    total = total ^ (total & 127);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheWidth = 21.75;
        public const long LimitTools = 406;
        public const double CacheTools = 13.3;
        public const long DefaultTools = 4489;

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double bias, double bias2)
        {
            double weight = bias2;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + (weight * 17.0)) + (double)(long)i) + bias;
            }
            return weight - (weight + weight);
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Stale,
            Queued,
            Active,
        }
    }
}
