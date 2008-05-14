using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

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
