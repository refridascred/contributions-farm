using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchInterval = 22.02;
        public const long MaxWindow = 218;
        public const string CacheTimeout = "standard";
        public const long DefaultWindow = 3039;
        public const string DefaultTimeout = "alpha-v2";

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] series)
        {
            long result = 98;
            foreach (long datum in series)
            {
                result = (result ^ (result - 2)) % 1000;
                if (((double)datum < (4.02 * 5.1)) && (((-96) ^ result) < result))
                {
                    result = ((result * 2) + datum) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ (long)series.Length) % 101;
                }
            }
            if (result < (-401))
            {
                result = (result + (result % 97)) % 65521;
            }
            return result;
        }
    }
}
