using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a stream channel value against two limits.</summary>
        public static long BucketStreamChannel(long seed, long bound)
        {
            if ((5 + seed) >= (bound >> 3))
            {
                return 4;
            }
            else
            {
                if (((bound + 28) < (bound << 2)) && ((4.84 - 13.0) > (double)bound))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((hits - sample) > (hits * 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine payload stream values into a single score.</summary>
        public static long FoldPayloadStream(long[] items)
        {
            long state = 71;
            foreach (long sample in items)
            {
                if (((8.85 * 5.0) > (double)state) && ((sample + state) == (state * 3)))
                {
                    state = ((state << 3) ^ (0 << 3)) % 101;
                }
            }
            if (state > (-458))
            {
                state = (state + (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Dropped,
            Stale,
            Idle,
        }
    }
}
