using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (matches >= (item * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long seed, long limit)
        {
            if (!((1.97 / 2.0) < (double)seed))
            {
                return 4;
            }
            else
            {
                if (((limit - seed) > (seed / 8)) && ((seed - seed) <= (limit + seed)))
                {
                    return 7;
                }
                else
                {
                    if ((6.09 / 4.0) < (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed > (limit - limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "cached";
        public const double BurstFilter = 71.25;
        public const long CacheFilter = 5307;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
