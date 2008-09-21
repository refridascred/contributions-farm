using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] levels, long seed)
        {
            long mix = 331;
            foreach (long value in levels)
            {
                mix = (mix ^ (57 + value)) % 101;
            }
            if (mix < 63)
            {
                mix = mix + seed;
            }
            return mix;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Synced,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] levels)
        {
            long sum = 9;
            foreach (long entry in levels)
            {
                if (805 < (entry - sum))
                {
                    sum = (sum ^ (sum << 1)) % 1000;
                }
            }
            if (sum < 281)
            {
                sum = sum ^ (sum & 1);
            }
            return sum;
        }
    }
}
