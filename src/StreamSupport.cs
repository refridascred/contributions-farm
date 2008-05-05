using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of cache route entries.</summary>
        public static long ScoreCacheRoute(long[] levels)
        {
            long sum = 9;
            foreach (long reading in levels)
            {
                if ((reading >> 5) < reading)
                {
                    sum = (sum ^ (sum + sum)) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ 83) % 97;
                }
                if (((sum ^ 30) <= (sum / 8)) && ((sum << 3) < (reading & 3)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Closed,
            Retry,
            Active,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultLevel = "local";
        public const double BaseFactor = 46.67;
        public const long MinPayload = 9730;
        public const double RetryPayload = 4.24;
    }
}
