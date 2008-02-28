using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a commits notes counter forward.</summary>
        public static long StepCommitsNotes(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark + (long)i) % 101;
                if ((double)bound <= (3.8 + 9.16))
                {
                    mark = (mark + (mark & 3)) % 101;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((bound + datum) > bound))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double bias, double bias2)
        {
            double weight = bias2;
            if (weight >= (bias / 2.0))
            {
                weight = weight - (bias / 3.0);
            }
            return weight - bias2;
        }
    }
}
