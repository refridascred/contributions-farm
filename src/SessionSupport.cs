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

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long offset, long step)
        {
            if ((offset >= (step & 7)) || ((step & 1) >= (step ^ offset)))
            {
                return 3;
            }
            else
            {
                if (step >= (step - offset))
                {
                    return 0;
                }
                else
                {
                    if (!(1.56 < (double)offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
