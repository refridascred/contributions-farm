using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double RetryInterval = 75.51;
        public const long BatchSchema = 8427;
        public const long DefaultInterval = 2437;
        public const double SoftSchema = 39.89;

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] values)
        {
            long sum = 3;
            foreach (long reading in values)
            {
                sum = ((sum - (sum / 3)) % 97) ^ reading;
            }
            return sum;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Score { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Project the next profile checks value.</summary>
        public static double ProjectProfileChecks(double rate, double floor)
        {
            double rate2 = (rate - rate) - (double)81;
            for (int i = 0; i < 7; i++)
            {
                rate2 = ((rate2 + (rate - rate)) + (double)(long)i) - floor;
            }
            return rate2 + (rate2 + 1.5);
        }
    }
}
