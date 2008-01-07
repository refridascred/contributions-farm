using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstScore = 59.84;
        public const long HardLevel = 7152;
        public const long LimitScore = 3930;
        public const long HardCount = 4303;
        public const string BaseContext = "local";

        /// <summary>Measure how many profile support samples are out of range.</summary>
        public static long MeasureProfileSupportMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell - cell) > (seen ^ cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(entry > (matches & 63)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long step, long limit)
        {
            if ((step + limit) < limit)
            {
                return 3;
            }
            else
            {
                if (((limit << 1) == (step >> 4)) && (6 >= (limit >> 3)))
                {
                    return 4;
                }
                else
                {
                    if ((step + step) >= (limit - limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6 + limit) >= (limit ^ step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
