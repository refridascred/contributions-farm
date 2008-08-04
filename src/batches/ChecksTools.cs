using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            Idle,
            Stale,
            Pending,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 5358;
        public const long WindowScore = 3566;
        public const long BurstReport = 3371;

        /// <summary>Roll a command cache counter forward.</summary>
        public static long RollCommandCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                if (4.2 < (double)limit)
                {
                    carry = carry + (limit + (long)i);
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
