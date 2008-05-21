using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double weight, double span)
        {
            double rate = (span / 3.0) - weight;
            if (rate > 7.53)
            {
                rate = rate - (double)(-81);
            }
            return rate + rate;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long seed, long offset)
        {
            long gap = seed - offset;
            if ((double)gap >= (double)offset)
            {
                return 5;
            }
            else
            {
                if (seed < (offset * 3))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Pending,
            Locked,
            New,
            Paused,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = mark - ((long)i + origin);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstLevel = 5148;
        public const long CacheSpan = 6436;
        public const string RetryWidth = "legacy";
        public const long SoftScore = 6184;
        public const long LimitSize = 5144;
    }
}
