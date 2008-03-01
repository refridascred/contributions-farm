using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample << 2) < 34)
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] readings)
        {
            long total = 0;
            foreach (long reading in readings)
            {
                total = ((total * 5) + (total & 63)) + reading;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseBudget = 8317;
        public const double RetryFormat = 15.46;
        public const long BurstSpan = 8067;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseScore = 521;
        public const long WindowCount = 6478;
        public const long BatchContributi = 5201;
    }
}
