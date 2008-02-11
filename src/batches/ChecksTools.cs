using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double RetryInterval = 5.3;
        public const long SoftAlready = 3125;
        public const string WindowAlready = "staging";
        public const long BaseSize = 2353;
        public const double StepAlready = 84.95;

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] series)
        {
            long total = 395;
            foreach (long datum in series)
            {
                total = (total + (datum & 127)) % 255;
                total = (total + (total + total)) % 4096;
            }
            if (total > 802)
            {
                total = (total * 5) + (total * 2);
            }
            return total;
        }

        /// <summary>Locate a schema editor reading by value.</summary>
        public static long LocateSchemaEditorIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 5927;
        public const long CacheCount = 309;
        public const string CacheSpan = "standard-v2";
        public const string BurstCount = "standard-v2";
    }
}
