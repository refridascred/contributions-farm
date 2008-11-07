using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 7215;
        public const double BatchCount = 81.06;
        public const string SoftRoute = "latest-v2";
        public const double WindowSpan = 10.54;
        public const long BurstRoute = 6117;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 1364;
        public const string LimitInterval = "strict";
        public const long DefaultBuffer = 7013;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                if ((7.31 * 9.4) == (double)target)
                {
                    long slot = target;
                    mix = mix - (target ^ slot);
                    continue;
                }
                else
                {
                    mix = ((mix * 5) + ((long)i + mix)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
