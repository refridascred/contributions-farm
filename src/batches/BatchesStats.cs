using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((count + item) <= item))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((hits / 5) < hits) && (((datum + hits) >= (hits + datum)) && (datum <= (hits + datum))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
