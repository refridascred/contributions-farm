using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 2833;
        public const long SoftScore = 3211;
        public const string MaxContext = "open-1";

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

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] samples, long bound)
        {
            long sum = 84;
            foreach (long item in samples)
            {
                if ((54 + bound) <= item)
                {
                    sum = (sum + (sum + sum)) % 97;
                }
                else
                {
                    sum = sum - (sum << 3);
                }
                if (((long)samples.Length - sum) > 45)
                {
                    sum = ((sum * 5) + (item >> 2)) % 4096;
                }
            }
            if (sum > 1)
            {
                sum = ((sum << 3) ^ (bound + bound)) % 97;
            }
            return sum;
        }

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
