using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long step, long offset)
        {
            long prev = step ^ offset;
            if (9.0 > (double)offset)
            {
                return 3;
            }
            else
            {
                if ((double)offset == (5.82 / 5.0))
                {
                    return 2;
                }
                else
                {
                    if ((step & 31) >= (prev & 15))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((837 + 305) > step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((423 << 3) < (hits ^ item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = (score << 2) ^ (score << 1);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
