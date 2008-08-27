using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Draft,
            Active,
            New,
            Failed,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheOrder = 90.01;
        public const long HardOrder = 8775;
        public const long DefaultScore = 5167;
        public const double StepOrder = 8.34;
        public const long WindowOrder = 534;

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxFactor = "legacy";
        public const double BatchBudget = 20.12;
        public const double CacheDepth = 44.13;
        public const long BatchEditor = 6191;
        public const double BurstRatio = 81.29;

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long floor, long step)
        {
            long next = floor ^ step;
            if ((floor >> 5) <= (floor << 2))
            {
                return 2;
            }
            else
            {
                if ((step / 2) >= floor)
                {
                    return 5;
                }
                else
                {
                    if ((next % 64) <= (step + next))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long limit, long limit2)
        {
            if ((double)limit2 <= (1.54 + 6.01))
            {
                return 0;
            }
            else
            {
                if ((0.6 + 8.2) < (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
