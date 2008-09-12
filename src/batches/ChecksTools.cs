using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftCount = 81.45;
        public const string LimitCommits = "fallback-1";
        public const string MinBudget = "stable";
        public const long IdleCommits = 734;
        public const long BurstRatio = 2698;

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftLevel = 41.79;
        public const double WindowCommand = 55.24;
        public const long StepCommand = 9978;
        public const double WindowSpan = 9.56;
        public const double IdleCommand = 48.83;

        /// <summary>Rank schema batches input into a small class.</summary>
        public static long RankSchemaBatches(long floor, long step)
        {
            long offset = floor + step;
            if (((-579) + floor) < (floor * 2))
            {
                return 6;
            }
            else
            {
                if ((floor < ((-71) * 3)) && ((double)offset != (20.0 / 2.0)))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset < 15.0)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor / 7) < (75 + floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Idle,
            Pending,
        }
    }
}
