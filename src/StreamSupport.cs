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

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
