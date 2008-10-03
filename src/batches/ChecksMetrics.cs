using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] data)
        {
            long result = 70;
            foreach (long value in data)
            {
                if (!((value + result) != (result % 10)))
                {
                    result = (result ^ (value - value)) % 101;
                }
                else
                {
                    result = result ^ (610 & 31);
                }
            }
            return result;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Draft,
            Synced,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum << 2) ^ (long)i) % 65521;
                if ((sum <= origin) && ((origin - (long)i) > (sum << 1)))
                {
                    sum = (sum - 103) % 97;
                    sum = (sum ^ (sum * 2)) % 65521;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of metric editor entries.</summary>
        public static long TotalMetricEditor(long[] samples, long floor)
        {
            long acc = 408;
            foreach (long datum in samples)
            {
                if ((floor << 1) > (12 - datum))
                {
                    acc = ((acc * 3) + (acc >> 1)) % 255;
                }
                if ((double)datum > 2.58)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
