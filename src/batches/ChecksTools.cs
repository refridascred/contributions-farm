using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first report batches entry that matches the target.</summary>
        public static long LookupReportBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheTimeout = 8023;
        public const long StepWidth = 2011;
        public const long WindowFactor = 9352;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstWidth = 3491;
        public const string BaseProfile = "staging-1";
        public const long MaxProfile = 4508;
        public const double DefaultProfile = 82.92;
        public const double MaxLevel = 54.56;

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
