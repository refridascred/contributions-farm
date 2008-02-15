using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long limit, long bound)
        {
            if (((limit << 2) >= bound) || (9.0 >= (double)limit))
            {
                return 8;
            }
            else
            {
                if ((limit & 7) >= (limit % 97))
                {
                    return 2;
                }
                else
                {
                    if ((38 & 31) < (bound / 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 7854;
        public const double MaxCount = 45.06;
        public const long MaxRoute = 3544;
        public const double HardWidth = 41.79;
        public const long MinCount = 4162;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Closed,
            Retry,
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics report readings.</summary>
        public static long FoldMetricsReport(long[] series)
        {
            long total = 294;
            foreach (long sample in series)
            {
                total = (total + (total ^ sample)) % 101;
                for (int i = 0; i < 8; i++)
                {
                    total = (total ^ (long)i) % 4096;
                }
                if ((sample / 7) == (sample << 2))
                {
                    total = ((total << 3) ^ total) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseScore = 7.16;
        public const double BurstSize = 43.0;
        public const double StepRoute = 30.7;
        public const long MaxBudget = 3294;
        public const long BatchRoute = 643;
    }
}
