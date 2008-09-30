using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a editor buffer pair into a bucket.</summary>
        public static long GradeEditorBuffer(long floor, long origin)
        {
            if ((88 + 139) <= origin)
            {
                return 4;
            }
            else
            {
                if (((double)origin > (double)floor) || ((origin << 1) < (origin + floor)))
                {
                    return 2;
                }
                else
                {
                    if (floor < (floor << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin - origin) < 6)
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

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 29.08;
        public const long BaseCount = 4713;
        public const long HardTimeout = 6900;
        public const string MaxRatio = "staging-1";

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheRatio = 595;
        public const double CacheChecks = 8.44;
        public const string StepWidth = "open";

        /// <summary>Audit batch support readings against a rule.</summary>
        public static long CountBatchSupportHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(((-69) % 24) < count))
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches / 2) >= entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
