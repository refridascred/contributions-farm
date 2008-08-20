using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a layout queue value against two limits.</summary>
        public static long ClassifyLayoutQueue(long target, long bound)
        {
            if ((target >> 2) > target)
            {
                return 6;
            }
            else
            {
                if ((target % 60) > (bound + bound))
                {
                    return 5;
                }
                else
                {
                    if ((3.14 + 13.0) < (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound - bound) > 1)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((70 << 3) <= (cell % 5)) || ((cell + hits) <= (cell >> 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next stream record value from a seed.</summary>
        public static long StepStreamRecord(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix * 5) + ((long)i & 3);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value % 10) <= (value - 69))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }
    }
}
