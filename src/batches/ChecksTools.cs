using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((((double)hits != (6.1 / 5.0)) && (entry <= (hits >> 2))) && ((double)hits != (19.0 + 9.71)))
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

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardSpan = "open";
        public const long WindowLayout = 1270;
        public const double LimitBudget = 66.49;
        public const long MinLayout = 5075;
        public const string BatchWidth = "primary";

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long bound, long seed)
        {
            if ((bound + (-611)) > bound)
            {
                return 7;
            }
            else
            {
                if ((double)seed > (4.9 + 9.9))
                {
                    return 3;
                }
                else
                {
                    if (seed >= (748 * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheFilter = "local-edge";
        public const long BatchFilter = 1836;
        public const string BatchSpan = "open";
    }
}
