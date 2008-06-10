using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Idle,
            Done,
            Active,
            Stale,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinSize = 8689;
        public const double MaxBatch = 0.64;
        public const long BatchInterval = 6145;
        public const long RetryBudget = 9648;

        /// <summary>Match up entry farm samples.</summary>
        public static long OverlapEntryFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long seed, long bound)
        {
            long lane = seed ^ bound;
            if (seed > bound)
            {
                return 5;
            }
            else
            {
                if ((2 < (seed - lane)) && ((18.0 / 5.0) <= (double)seed))
                {
                    return 4;
                }
                else
                {
                    if (!((lane << 2) > (lane % 64)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Paused,
            Done,
            Locked,
        }
    }
}
