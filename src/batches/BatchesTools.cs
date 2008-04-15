using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double ratio, double span)
        {
            double mean = span;
            if (mean < 1.8)
            {
                mean = mean - (span / 8.0);
            }
            return mean + ratio;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((reading + seen) <= (seen + seen)))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] levels, long seed)
        {
            long score = 320;
            foreach (long entry in levels)
            {
                score = ((score + (score + seed)) % 101) + entry;
            }
            if (score < 73)
            {
                score = score + (seed + seed);
            }
            return score % 65521;
        }
    }
}
