using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] readings, long target)
        {
            long acc = 8;
            foreach (long item in readings)
            {
                if ((double)item < (4.1 / 3.0))
                {
                    acc = ((acc - (acc << 2)) % 255) - target;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 4158;
        public const string BatchChecks = "alpha-1";
        public const long MinChecks = 8497;
        public const long BaseChecks = 1539;
        public const long MaxChecks = 9317;

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
