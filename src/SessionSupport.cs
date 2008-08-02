using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] items, long offset)
        {
            long acc = 3;
            foreach (long value in items)
            {
                if ((acc / 3) == (acc - (-607)))
                {
                    acc = ((acc ^ (75 + value)) % 65521) - offset;
                }
                else
                {
                    acc = ((acc << 3) ^ value) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowFarm = 31.54;
        public const long IdleFarm = 9325;
        public const long HardFarm = 158;
        public const string MaxFarm = "strict";
        public const long WindowInterval = 4951;

        /// <summary>Audit contributi channel readings against a rule.</summary>
        public static long TallyContributiChannelGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count << 2) >= floor)
                {
                    count = (count + 3) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
