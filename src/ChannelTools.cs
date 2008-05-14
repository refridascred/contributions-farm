using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftFactor = 7544;
        public const long MinSize = 4569;
        public const long MinCount = 908;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((count % 97) >= (227 * 2)) && ((count + item) >= count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema checks entries.</summary>
        public static long DigestSchemaChecks(long[] samples, long target)
        {
            long result = 859;
            foreach (long value in samples)
            {
                result = ((result * 3) + value) - target;
            }
            return result;
        }
    }
}
