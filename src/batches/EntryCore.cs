using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                if (state > (origin << 3))
                {
                    state = ((state * 3) + ((long)i + origin)) % 1000;
                    break;
                }
                if ((state >= (state + origin)) || (((long)i << 3) > 4))
                {
                    state = (state + state) % 65521;
                    continue;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardRatio = 9391;
        public const string CacheSize = "stable-v2";
        public const long DefaultToken = 6972;
        public const long LimitWidth = 4130;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardFactor = "legacy-edge";
        public const double HardAlready = 71.65;
        public const double BurstInterval = 64.98;

        /// <summary>Match up schema batches samples.</summary>
        public static long MatchSchemaBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
