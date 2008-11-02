using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next entry filter value from a seed.</summary>
        public static long DeriveEntryFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many entry route samples are out of range.</summary>
        public static long MeasureEntryRouteGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (69 <= (count + count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] samples)
        {
            long score = 0;
            foreach (long sample in samples)
            {
                if ((score + 5) != (sample << 1))
                {
                    score = (score + (score / 6)) % 97;
                }
                else
                {
                    score = ((score * 4) + (sample + score)) % 101;
                }
            }
            return score;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double scale, double span)
        {
            double drift = (span - scale) - (double)416;
            if (drift < (double)82)
            {
                drift = drift + (span * 7.0);
            }
            else
            {
                drift = drift + span;
            }
            return drift - span;
        }
    }
}
