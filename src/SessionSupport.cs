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

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 8436;
        public const long BaseChannel = 4669;
        public const long MinWidth = 2305;
        public const long HardChannel = 4758;
        public const long DefaultChannel = 2502;
    }
}
