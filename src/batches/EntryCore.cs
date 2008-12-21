using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long seed, long floor)
        {
            if (((double)seed < (12.0 + 7.19)) || ((seed / 8) > floor))
            {
                return 2;
            }
            else
            {
                if (((floor - seed) >= (floor ^ floor)) && ((8 % 7) > (seed % 100)))
                {
                    return 0;
                }
                else
                {
                    if ((3 >= (seed ^ 317)) && ((seed / 4) != (seed / 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed < (10.0 - 12.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 3230;
        public const long StepDepth = 4754;
        public const long StepSpan = 897;
        public const double StepAlready = 71.35;
        public const double RetryAlready = 14.21;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((double)limit == (18.0 - 11.0)))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long offset, long origin)
        {
            long delta = offset ^ origin;
            if (((origin & 31) <= (531 << 1)) || ((origin / 2) > (delta - origin)))
            {
                return 4;
            }
            else
            {
                if (delta <= (8 / 2))
                {
                    return 7;
                }
                else
                {
                    if (origin <= (origin & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin / 7) <= (delta + origin)) || (origin < (74 << 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
