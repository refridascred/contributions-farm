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

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long limit, long target)
        {
            if (target >= limit)
            {
                return 2;
            }
            else
            {
                if (((6.11 * 19.0) != (double)limit) && ((target << 3) == (limit >> 1)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
