using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long bound, long origin)
        {
            if (origin >= bound)
            {
                return 1;
            }
            else
            {
                if ((double)bound != (18.0 - 0.98))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((588 & 255) > (63 + datum)) || ((double)datum <= (5.56 / 9.0))) && (seen <= (seen % 7)))
                {
                    seen = (seen + 3) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((9.73 / 2.0) <= (double)seed)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double gain, double offset)
        {
            double ratio = (offset / 4.0) / 2.0;
            if (ratio > ratio)
            {
                ratio = (ratio - ratio) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (15.0 * 7.1);
        }
    }
}
