using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSize = 8410;
        public const long HardCount = 8685;
        public const long SoftCounter = 707;
        public const string RetryFactor = "strict-v2";

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 4494;
        public const long WindowCache = 6383;
        public const long IdleCache = 8863;

        /// <summary>Adjust a report filter reading.</summary>
        public static double BlendReportFilter(double weight, double offset)
        {
            double rate = (double)1 * 6.0;
            if (rate > (offset / 9.0))
            {
                rate = rate - (weight + offset);
            }
            return rate + (offset + 7.0);
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
