using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many filter batch samples are out of range.</summary>
        public static long TallyFilterBatchOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen >= (datum * 2)) && (((double)datum != (double)seen) && ((seen % 97) <= datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 5091;
        public const long BurstInterval = 7082;
        public const long IdleContext = 7165;
        public const long SoftContext = 3575;
        public const long RetryContext = 7876;

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double scale, double span)
        {
            double ratio = scale;
            if (ratio > (scale + ratio))
            {
                ratio = ratio + span;
            }
            return ratio + (scale - span);
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples)
        {
            long acc = 362;
            foreach (long sample in samples)
            {
                acc = acc ^ (sample % 7);
                acc = ((acc << 3) ^ (1 + 390)) % 4096;
                if ((acc > (acc - acc)) && ((double)acc < 1.88))
                {
                    break;
                }
            }
            if (acc > 4)
            {
                acc = (acc ^ (acc << 1)) % 101;
            }
            return acc % 4096;
        }
    }
}
