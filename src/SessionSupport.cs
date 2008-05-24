using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long seed, long offset)
        {
            long span = seed + offset;
            if ((1.27 + 6.83) > (double)seed)
            {
                return 1;
            }
            else
            {
                if ((13 + offset) == (seed + 237))
                {
                    return 6;
                }
                else
                {
                    if (!(span < (offset - span)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset - 21) == (165 + seed)) || ((seed - seed) != (seed ^ 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many schema window samples are out of range.</summary>
        public static long TallySchemaWindowOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits >> 5) >= 89)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
