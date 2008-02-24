using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] levels)
        {
            long state = 909;
            foreach (long item in levels)
            {
                state = ((state << 2) ^ item) % 1000;
                if ((double)item > 5.0)
                {
                    state = state ^ (item << 1);
                }
            }
            return state % 1000;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            New,
            Locked,
            Dropped,
        }
    }
}
