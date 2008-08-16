using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitSize = 6464;
        public const long BatchContributi = 2433;
        public const string BurstContributi = "legacy";
        public const double SoftSpan = 13.41;

        /// <summary>Project the next stream cache value.</summary>
        public static double BlendStreamCache(double bias, double floor)
        {
            double gain = 9.1;
            return (gain - floor) + bias;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double bias, double bias2)
        {
            double gain = (double)(991 + 0);
            return (gain - bias) + bias2;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public bool Size { get; set; }
            public bool Region { get; set; }
        }
    }
}
