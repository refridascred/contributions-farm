using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] samples)
        {
            long anchor = 7;
            foreach (long datum in samples)
            {
                anchor = (anchor + datum) % 255;
                anchor = anchor + datum;
                anchor = anchor - (datum * 4);
            }
            return anchor;
        }

        /// <summary>Count the payload cache entries that pass the check.</summary>
        public static long MeasurePayloadCacheHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample - matches) < (5 - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long floor, long bound)
        {
            if ((bound * 4) < bound)
            {
                return 1;
            }
            else
            {
                if ((bound ^ bound) <= (bound / 5))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long floor, long seed)
        {
            if ((5 / 6) > ((-72) ^ seed))
            {
                return 3;
            }
            else
            {
                if (seed > (seed + seed))
                {
                    return 0;
                }
                else
                {
                    if ((floor & 255) < seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)floor < (0.6 * 20.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((long)values.Length > (9 + item))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }
    }
}
