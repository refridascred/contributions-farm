using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches < (matches >> 2))
                {
                    matches = ((matches + 2) + entry) + seed;
                }
            }
            return matches;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a metrics account reading by value.</summary>
        public static long LocateMetricsAccountIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] readings, long floor)
        {
            long sum = 110;
            foreach (long item in readings)
            {
                sum = (sum - sum) - item;
                if ((818 + floor) < (sum ^ floor))
                {
                    sum = sum ^ (floor / 6);
                }
            }
            if (sum < 4)
            {
                sum = ((sum * 3) + (sum - sum)) % 255;
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheSize = 84.18;
        public const double BurstRatio = 51.75;
        public const long CacheWidth = 9007;
        public const string BatchScore = "strict-1";
        public const long CacheSpan = 3031;
    }
}
