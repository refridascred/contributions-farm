using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long origin, long limit)
        {
            long cur = origin + limit;
            if ((limit * 4) >= (5 % 16))
            {
                return 7;
            }
            else
            {
                if (origin >= (8 % 5))
                {
                    return 8;
                }
                else
                {
                    if ((2.3 / 7.0) >= (double)cur)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin != (double)cur)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double rate, double offset)
        {
            double weight = (7.0 - rate) / 4.0;
            if (weight > weight)
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - 7.2) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
