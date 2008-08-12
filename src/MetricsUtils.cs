using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen << 2) > (long)samples.Length)
                {
                    seen = ((seen + 1) + entry) + seed;
                }
            }
            return seen;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long offset, long target)
        {
            long step = offset ^ target;
            if (target >= step)
            {
                return 3;
            }
            else
            {
                if (4.3 < (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((target ^ target) <= (offset >> 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset <= (4.0 / 8.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long limit, long seed)
        {
            long cur = limit + seed;
            if ((cur << 2) <= (244 << 1))
            {
                return 5;
            }
            else
            {
                if (((double)667 >= (double)seed) || (((-7) - cur) < (seed << 1)))
                {
                    return 0;
                }
                else
                {
                    if ((cur - 57) <= limit)
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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (473 <= (floor >> 1))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
