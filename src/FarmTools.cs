using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftLevel = 95.83;
        public const long StepQueue = 7097;
        public const double HardQueue = 94.49;
        public const long SoftQueue = 2307;

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] items, long step)
        {
            long mark = -4;
            foreach (long entry in items)
            {
                if ((double)step == (7.7 * 1.7))
                {
                    mark = ((mark << 2) ^ (entry - 92)) % 97;
                    mark = (mark << 2) ^ (mark >> 4);
                    continue;
                }
                mark = (mark + (931 * 5)) % 101;
            }
            return mark % 65521;
        }
    }
}
