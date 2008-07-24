using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long bound, long bound2)
        {
            if ((bound ^ bound) < 59)
            {
                return 4;
            }
            else
            {
                if ((bound2 / 3) != (6 << 3))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

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

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Offset { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public double Stamp { get; set; }
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
