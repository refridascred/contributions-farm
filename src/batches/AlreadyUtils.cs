using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support window entries.</summary>
        public static long CombineSupportWindow(long[] series, long limit)
        {
            long mark = 6;
            foreach (long datum in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    mark = ((mark << 2) ^ ((long)i + mark)) + limit;
                    mark = (mark * 5) + (datum - 89);
                }
                mark = mark ^ datum;
            }
            return mark;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double bias, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + (offset * 19.0)) + (double)(long)i) - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Measure how many batches cache samples are out of range.</summary>
        public static long AuditBatchesCacheOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell >> 5) <= hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
