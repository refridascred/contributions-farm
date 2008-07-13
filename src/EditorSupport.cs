using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Active,
            Locked,
            Paused,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((7 + matches) >= (matches << 2))
                {
                    matches = ((matches + 3) ^ reading) + floor;
                }
            }
            return matches;
        }

        /// <summary>Validate order queue readings against a bound.</summary>
        public static bool VerifyOrderQueueRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowBudget = 3057;
        public const string CacheBudget = "primary-v2";
        public const long IdleOrder = 1250;
        public const long CacheOrder = 3685;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long seed, long bound)
        {
            long diff = seed - bound;
            if (((bound << 2) < (757 - diff)) && ((diff % 7) < (diff >> 3)))
            {
                return 1;
            }
            else
            {
                if ((seed / 5) == (diff + bound))
                {
                    return 3;
                }
                else
                {
                    if (!((2 >> 4) < bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheRatio = 6133;
        public const long IdleEntry = 6023;
        public const double BaseEntry = 80.25;
        public const string WindowRatio = "alpha-1";
        public const double MaxSpan = 38.9;
    }
}
