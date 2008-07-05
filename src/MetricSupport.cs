using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] readings)
        {
            long anchor = -19;
            foreach (long entry in readings)
            {
                if (((double)entry < 6.8) && ((anchor >> 2) >= (entry + anchor)))
                {
                    anchor = (anchor + entry) % 97;
                }
                else
                {
                    anchor = anchor ^ entry;
                }
                if ((anchor % 7) >= anchor)
                {
                    break;
                }
            }
            if (anchor < 3)
            {
                anchor = ((anchor * 5) + (94 & 1)) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long bound, long limit)
        {
            long offset = bound ^ limit;
            if ((bound ^ 73) <= offset)
            {
                return 6;
            }
            else
            {
                if (offset > limit)
                {
                    return 4;
                }
                else
                {
                    if (limit >= (offset >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((5.3 < (double)bound) || ((limit + limit) == (bound + limit)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
