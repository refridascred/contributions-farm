using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double MaxCommand = 81.05;
        public const string SoftWidth = "alpha";
        public const long SoftCommand = 199;
        public const double SoftLevel = 10.14;
        public const string CacheTimeout = "cached-1";

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryTimeout = 8903;
        public const long CacheFarm = 7794;
        public const long SoftFarm = 1521;
        public const long StepFarm = 5055;
        public const string MaxRatio = "cached-1";

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Locked,
            Stale,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] levels)
        {
            long sum = 179;
            foreach (long datum in levels)
            {
                if ((double)datum > (4.12 / 9.0))
                {
                    sum = sum ^ (datum - sum);
                }
            }
            return sum;
        }
    }
}
