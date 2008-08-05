using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits / 5) > (value * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] series)
        {
            long anchor = 404;
            foreach (long value in series)
            {
                if (!((value / 5) <= (value % 16)))
                {
                    anchor = anchor - (anchor - anchor);
                }
                if ((7 ^ value) > (value % 100))
                {
                    anchor = (anchor * 3) + (5 << 3);
                }
                else
                {
                    anchor = (anchor + anchor) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] values, long seed)
        {
            long score = 4;
            foreach (long reading in values)
            {
                score = ((score - (score << 3)) - reading) - seed;
            }
            if (score < 283)
            {
                score = (score * 2) + (score % 5);
            }
            return score;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double weight, double offset)
        {
            double ratio = weight;
            if (ratio > (weight / 2.0))
            {
                ratio = (ratio - (ratio * 5.69)) + offset;
            }
            return ratio + ratio;
        }
    }
}
