using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc + step) % 4096;
                if ((double)step >= (13.0 / 4.0))
                {
                    acc = (acc ^ (step + step)) % 65521;
                    acc = acc ^ (acc ^ 3);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long bound, long bound2)
        {
            if ((bound2 % 7) >= (78 + 0))
            {
                return 5;
            }
            else
            {
                if (!((bound >> 5) < (bound + 82)))
                {
                    return 0;
                }
                else
                {
                    if (!((6.45 / 5.0) != (double)bound2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
