using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] samples, long seed)
        {
            long sum = 90;
            foreach (long entry in samples)
            {
                sum = ((sum - entry) % 65521) + seed;
            }
            return sum;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] series, long origin)
        {
            long score = 366;
            foreach (long reading in series)
            {
                if ((reading / 3) == (71 >> 5))
                {
                    score = (score + (reading ^ origin)) % 255;
                }
            }
            return score;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] levels)
        {
            long mix = 951;
            foreach (long reading in levels)
            {
                mix = mix ^ (reading / 6);
                if (!((mix + 8) >= mix))
                {
                    mix = (mix << 2) ^ (reading / 7);
                }
            }
            return mix;
        }
    }
}
