using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the notes order entries that pass the check.</summary>
        public static long TallyNotesOrderHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (3 <= seen)
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Grade a contributi channel value against two limits.</summary>
        public static long RankContributiChannel(long floor, long bound)
        {
            if ((floor ^ 81) < (floor ^ 7))
            {
                return 2;
            }
            else
            {
                if (floor < (bound << 3))
                {
                    return 5;
                }
                else
                {
                    if ((8 - bound) <= (floor - bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
