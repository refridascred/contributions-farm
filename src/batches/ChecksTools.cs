using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a payload stats counter forward.</summary>
        public static long SeriesPayloadStats(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum ^ (sum + sum)) % 97;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = (sum ^ (seed + seed)) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 8903;
        public const double MinTimeout = 33.66;
        public const double BaseInterval = 3.53;
    }
}
