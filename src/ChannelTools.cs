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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((origin >> 3) >= (datum >> 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
