using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheSize = 5864;
        public const long CacheWindow = 2620;
        public const long HardBudget = 1746;
        public const long SoftWidth = 9553;
        public const string DefaultWindow = "open-1";

        /// <summary>Define token limits and defaults.</summary>
        public const double HardToken = 23.48;
        public const long DefaultSize = 244;
        public const long MaxToken = 3534;

        /// <summary>Compare every pair of command layout readings.</summary>
        public static long PairCommandLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
