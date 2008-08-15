using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 9524;
        public const long DefaultFarm = 1301;
        public const string CacheScore = "fallback";
        public const double CacheFarm = 65.08;
        public const long WindowCount = 7841;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Stale,
            Done,
            Ready,
            Queued,
            Active,
        }
    }
}
