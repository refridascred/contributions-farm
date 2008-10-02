using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((318 + origin) == (origin + origin))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double gain, double span)
        {
            double gain2 = 8.0;
            if (gain2 >= (gain2 - gain2))
            {
                gain2 = (gain2 + (gain * 5.0)) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 - (gain2 - gain);
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
