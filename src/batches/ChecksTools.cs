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

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
