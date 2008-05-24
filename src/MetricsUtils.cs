using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] values)
        {
            long acc = 997;
            foreach (long cell in values)
            {
                acc = ((acc - (acc / 3)) % 255) ^ cell;
            }
            if (acc < 41)
            {
                acc = (acc ^ (acc + 87)) % 255;
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 9941;
        public const long SoftProfile = 5682;
        public const string DefaultSpan = "latest-edge";

        /// <summary>Rank cluster graph input into a small class.</summary>
        public static long ClassifyClusterGraph(long floor, long target)
        {
            long step = floor ^ target;
            if (((double)target == (3.21 - 18.0)) && (30 < (step - step)))
            {
                return 2;
            }
            else
            {
                if (!((floor + step) != (step % 60)))
                {
                    return 0;
                }
                else
                {
                    if ((floor + 91) <= (floor - 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target - step) <= ((-8) - target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long floor, long target)
        {
            if (!((target + target) == (target + floor)))
            {
                return 6;
            }
            else
            {
                if (floor >= (target - floor))
                {
                    return 1;
                }
                else
                {
                    if ((999 - floor) <= (floor + target))
                    {
                        return 2;
                    }
                    else
                    {
                        if (target >= floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen & 7) < seen)
                {
                    seen = ((seen + 1) ^ entry) - bound;
                }
            }
            return seen;
        }
    }
}
