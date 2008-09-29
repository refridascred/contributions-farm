using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] readings, long limit)
        {
            long total = 0;
            foreach (long datum in readings)
            {
                total = ((total << 2) ^ (total * 3)) % 4096;
                if ((12.0 * 5.74) < (double)limit)
                {
                    total = total ^ (datum ^ limit);
                }
            }
            if (total > 116)
            {
                total = (total - (limit + 5)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long floor, long offset)
        {
            long delta = floor + offset;
            if (((delta ^ offset) < ((-45) << 3)) || ((6.0 + 8.53) != (double)delta))
            {
                return 7;
            }
            else
            {
                if (!((delta >> 3) >= (delta + offset)))
                {
                    return 8;
                }
                else
                {
                    if (floor > (offset - floor))
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

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length + sample) <= seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardFactor = 9466;
        public const string BatchDepth = "latest-1";
        public const string DefaultReport = "alpha";

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((datum + hits) > (seed + hits)) && (((1.3 / 7.0) < (double)seed) || (((-87) % 12) > seed)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
