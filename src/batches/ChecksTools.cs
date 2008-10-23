using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine batches cluster values into a single score.</summary>
        public static long WeighBatchesCluster(long[] samples, long offset)
        {
            long result = 5;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = ((result * 2) + (offset - entry)) ^ (long)i;
                }
                result = result ^ (entry << 2);
            }
            if (result > 785)
            {
                result = (result + 499) % 255;
            }
            return result;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long step, long origin)
        {
            long step2 = step ^ origin;
            if ((double)step > (1.1 + 4.6))
            {
                return 0;
            }
            else
            {
                if ((step2 * 5) >= step)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits <= (datum & 3)) || ((datum >> 4) < (datum - datum)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (offset >= (0 & 255))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
