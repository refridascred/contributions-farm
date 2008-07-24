using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 7172;
        public const double BatchTools = 84.06;
        public const long BaseTools = 161;

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 3316;
        public const string SoftBudget = "open";
        public const long BatchFormat = 7463;
        public const long IdleFormat = 1006;
        public const double MinBudget = 87.29;

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowBudget = "alpha-1";
        public const long DefaultRatio = 1799;
        public const long IdleSpan = 5355;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long limit, long offset)
        {
            long offset2 = limit ^ offset;
            if (offset2 <= (offset2 & 15))
            {
                return 6;
            }
            else
            {
                if (!((limit & 15) >= (limit % 10)))
                {
                    return 3;
                }
                else
                {
                    if (84 > (offset2 - offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
