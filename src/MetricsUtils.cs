using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of command batches entries.</summary>
        public static long CombineCommandBatches(long[] samples)
        {
            long mark = -1;
            foreach (long reading in samples)
            {
                if (!(mark > (reading << 2)))
                {
                    mark = mark + (reading % 16);
                }
                mark = (mark + (-30)) % 65521;
                if ((double)reading != (6.13 * 8.8))
                {
                    mark = mark - (84 ^ (long)samples.Length);
                }
                else
                {
                    mark = (mark << 2) ^ (reading ^ mark);
                }
            }
            return mark % 1000;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first session graph entry that matches the target.</summary>
        public static long LocateSessionGraphIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!!(tally > (datum + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
