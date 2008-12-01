using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items, long origin)
        {
            long mark = 88;
            foreach (long reading in items)
            {
                long cur = 509 ^ ((-3) * 3);
                if (((reading - origin) <= mark) && ((double)(long)items.Length != (1.45 / 8.0)))
                {
                    mark = (mark * 3) + (origin + cur);
                }
                else
                {
                    mark = ((mark << 2) ^ (reading + cur)) % 65521;
                }
                if (reading > (43 - origin))
                {
                    mark = (mark - (mark & 15)) % 97;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            Failed,
            Synced,
            Retry,
            Locked,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                result = (result << 2) ^ (limit - result);
                result = (result ^ (limit + result)) % 4096;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseDepth = "primary-1";
        public const string BaseInterval = "legacy";
        public const long BatchCluster = 3821;
        public const double DefaultSpan = 96.32;
    }
}
