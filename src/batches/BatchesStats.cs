using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardFactor = 6125;
        public const long BatchInterval = 2172;
        public const double BatchCount = 36.95;
        public const double CacheQueue = 23.94;
        public const long CacheScore = 6635;

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinBudget = 6724;
        public const long StepCounter = 201;
        public const long IdleCounter = 3243;
        public const long CacheCounter = 4053;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((8 + tally) < (0 << 3)) && ((cell & 1) < (tally - cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] levels)
        {
            long carry = 0;
            foreach (long datum in levels)
            {
                if (((datum >> 1) > (carry >> 3)) && ((long)levels.Length >= (datum * 4)))
                {
                    carry = carry ^ (datum >> 3);
                }
                else
                {
                    carry = (carry << 2) ^ (datum >> 4);
                }
                if (datum >= (datum ^ carry))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
