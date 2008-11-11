using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)seen < 16.0)
                {
                    seen = ((seen + 1) - sample) - seed;
                }
            }
            return seen;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long floor, long origin)
        {
            if (floor >= (origin & 31))
            {
                return 1;
            }
            else
            {
                if (!((origin - origin) < origin))
                {
                    return 7;
                }
                else
                {
                    if ((origin - floor) == (floor + 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((origin ^ origin) <= floor) || ((origin - origin) < (floor + floor)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((limit % 5) >= item) || ((seen - seen) <= (950 * 4))) && ((double)seen < (double)limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
