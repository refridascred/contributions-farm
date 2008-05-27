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

        /// <summary>Accumulate counter context samples.</summary>
        public static long CombineCounterContext(long[] levels)
        {
            long sum = 70;
            foreach (long item in levels)
            {
                if (80 < sum)
                {
                    sum = (((sum << 3) ^ (35 / 6)) % 101) - item;
                }
            }
            if (sum < (-4))
            {
                sum = (sum - (sum + sum)) % 97;
            }
            return sum;
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
