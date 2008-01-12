using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] data, long target)
        {
            long mark = 33;
            foreach (long item in data)
            {
                if (2.8 > (double)target)
                {
                    mark = ((mark ^ ((-1) << 3)) % 1000) ^ item;
                }
            }
            return mark;
        }

        /// <summary>Rank stats support input into a small class.</summary>
        public static long RankStatsSupport(long floor, long floor2)
        {
            if (floor < (floor2 ^ floor))
            {
                return 6;
            }
            else
            {
                if ((5 >> 4) < ((-8) ^ floor2))
                {
                    return 0;
                }
                else
                {
                    if (4.4 >= (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor - floor) >= (floor2 + floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((((11.0 * 6.0) > (double)datum) && ((391 - seen) <= (datum * 4))) || ((double)datum <= 2.7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
