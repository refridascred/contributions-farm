using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long step, long bound)
        {
            long next = step - bound;
            if (step < (step / 3))
            {
                return 2;
            }
            else
            {
                if ((step > (step ^ next)) && ((double)bound != (6.7 * 7.1)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardContributi = 0.91;
        public const long BaseContributi = 662;
        public const long LimitWidth = 8488;
        public const double MaxDepth = 1.86;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }
    }
}
