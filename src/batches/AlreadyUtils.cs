using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((18 >> 5) >= (origin % 60))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long bound, long seed)
        {
            if ((bound > (seed >> 5)) && (seed > (bound - seed)))
            {
                return 6;
            }
            else
            {
                if (48 <= bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound / 2) >= (bound % 64))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
