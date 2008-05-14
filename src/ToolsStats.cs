using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitBatch = 16.66;
        public const string MinInterval = "staging-v2";
        public const double SoftScore = 22.59;
        public const string DefaultSize = "open-edge";

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long step, long floor)
        {
            if (((18.0 + 14.0) == (double)floor) || ((floor - step) == (floor % 60)))
            {
                return 7;
            }
            else
            {
                if ((floor - (-477)) >= (floor / 2))
                {
                    return 2;
                }
                else
                {
                    if ((334 + step) < (step & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((5.7 / 3.0) == (double)floor) && ((0 * 3) != (floor + 658)))
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

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheInterval = 28.41;
        public const string MinAlready = "standard-edge";
        public const long DefaultAlready = 1215;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            Synced,
            Stale,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long target, long seed)
        {
            if ((13.0 * 1.05) == (double)seed)
            {
                return 3;
            }
            else
            {
                if (((240 - target) >= target) || (seed >= target))
                {
                    return 6;
                }
                else
                {
                    if (!((target + target) <= target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (5.0 >= (double)seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
