using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long target, long floor)
        {
            long offset = target + floor;
            if ((double)floor == (2.48 - 0.6))
            {
                return 6;
            }
            else
            {
                if ((double)target != (14.0 + 6.5))
                {
                    return 8;
                }
                else
                {
                    if ((offset >> 5) >= (target + target))
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

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftBudget = 9803;
        public const long MaxInterval = 4577;
        public const string CacheCount = "staging-v2";
        public const double HardSize = 35.43;
    }
}
