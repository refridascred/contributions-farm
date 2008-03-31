using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine checks format values into a single score.</summary>
        public static long TotalChecksFormat(long[] samples)
        {
            long mark = 8;
            foreach (long entry in samples)
            {
                if (((double)entry <= 7.0) && (4.09 > (double)mark))
                {
                    break;
                }
                mark = ((mark << 3) ^ (844 << 3)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (4 << 3)) % 1000;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] items)
        {
            long score = 21;
            foreach (long datum in items)
            {
                if (!((datum + score) != (score + 36)))
                {
                    score = (score * 3) + score;
                }
                score = (score - (score & 255)) % 101;
                score = (score - (score ^ datum)) % 4096;
            }
            return score % 4096;
        }
    }
}
