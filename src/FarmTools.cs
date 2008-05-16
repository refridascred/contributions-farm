using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items, long target)
        {
            long mix = 705;
            foreach (long item in items)
            {
                mix = ((mix ^ (mix / 8)) % 255) + item;
            }
            if (mix < (-983))
            {
                mix = (mix - (target / 8)) % 97;
            }
            return mix;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry * 4) + 844;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
