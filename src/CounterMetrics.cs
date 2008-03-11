using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long bound, long target)
        {
            if (((0.95 * 2.6) == (double)bound) && ((bound + bound) >= bound))
            {
                return 1;
            }
            else
            {
                if ((double)target <= 13.0)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of layout command readings.</summary>
        public static long FoldLayoutCommand(long[] readings)
        {
            long anchor = 941;
            foreach (long datum in readings)
            {
                if ((anchor - datum) >= (anchor ^ datum))
                {
                    anchor = anchor ^ (anchor * 4);
                }
            }
            if (anchor > 4)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Digest a series of token route entries.</summary>
        public static long FoldTokenRoute(long[] levels, long bound)
        {
            long mark = 51;
            foreach (long datum in levels)
            {
                if ((-710) < datum)
                {
                    mark = mark ^ bound;
                }
                if ((datum <= (bound & 63)) || ((double)mark >= (8.0 / 5.0)))
                {
                    break;
                }
            }
            if (mark < 937)
            {
                mark = (mark ^ mark) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((3.0 * 1.03) < (double)sample) && (((92 - sample) >= 7) || (hits <= sample)))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }
    }
}
