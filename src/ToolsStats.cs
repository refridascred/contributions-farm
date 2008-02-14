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

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitBudget = 6467;
        public const double HardQueue = 59.39;
        public const string IdleSize = "open";
        public const double WindowQueue = 42.99;
        public const long BatchTimeout = 843;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Synced,
            Queued,
            Dropped,
            Locked,
            Done,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftCount = 9296;
        public const long LimitScore = 4460;
        public const long BurstDepth = 2022;

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseScore = 7.16;
        public const double BurstSize = 43.0;
        public const double StepRoute = 30.7;
        public const long MaxBudget = 3294;
        public const long BatchRoute = 643;
    }
}
