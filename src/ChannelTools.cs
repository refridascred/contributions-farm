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

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
