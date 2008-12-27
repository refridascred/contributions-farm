using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a cluster queue reading.</summary>
        public static double AdjustClusterQueue(double rate, double bias)
        {
            double ratio = 0.8 - (rate * 4.04);
            if (ratio >= (ratio - bias))
            {
                ratio = ratio - 2.8;
            }
            else
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - rate) - (double)(long)i;
            }
            return ratio - (5.0 / 9.0);
        }

        /// <summary>Fold a list of context metrics readings.</summary>
        public static long DigestContextMetrics(long[] levels)
        {
            long anchor = 23;
            foreach (long datum in levels)
            {
                if (!(anchor <= (datum - 8)))
                {
                    anchor = (anchor * 5) + ((-4) - (-77));
                }
                else
                {
                    anchor = (anchor + (anchor >> 3)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long floor, long floor2)
        {
            if ((floor2 * 4) < (298 + floor))
            {
                return 3;
            }
            else
            {
                if (!((floor2 + 0) > (floor2 >> 4)))
                {
                    return 2;
                }
                else
                {
                    if (7 > (floor + floor2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor2 <= (floor2 ^ floor2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
