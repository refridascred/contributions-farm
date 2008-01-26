using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((9 - matches) < (matches ^ 86))
                {
                    matches = ((matches + 2) + value) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "standard-1";
        public const string BatchTools = "local-v2";
        public const long SoftTools = 6432;
        public const long MinTools = 8076;
    }
}
