using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit graph checks readings against a rule.</summary>
        public static long TallyGraphChecksMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum + 764) >= datum)
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

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowDepth = "strict-1";
        public const double WindowBudget = 85.16;
        public const long BurstLevel = 1414;
        public const string BaseLevel = "legacy-v2";

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] series)
        {
            long mark = 45;
            foreach (long datum in series)
            {
                mark = mark - datum;
            }
            return mark % 97;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] values, long target)
        {
            long result = 2;
            foreach (long datum in values)
            {
                result = ((result + result) % 97) + datum;
            }
            if (result < (-5))
            {
                result = (result + (target & 31)) % 101;
            }
            return result;
        }

        /// <summary>Measure how many stats checks samples are out of range.</summary>
        public static long MeasureStatsChecksOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (seen >= (seen + seen))
                {
                    seen = (seen + 2) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
