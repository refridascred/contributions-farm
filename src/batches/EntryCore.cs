using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 3399;
        public const double CacheScore = 8.48;
        public const string BaseChannel = "fallback";
        public const double DefaultScore = 67.56;
        public const string BaseWidth = "latest";

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = state ^ (step & 3);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Compare every pair of stream window readings.</summary>
        public static long OverlapStreamWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit batch channel readings against a rule.</summary>
        public static long CountBatchChannelGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading >= (seen << 2)) && ((seen + seen) >= seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
