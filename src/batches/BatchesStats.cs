using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] levels, long target)
        {
            long mark = 97;
            foreach (long value in levels)
            {
                if ((target + 340) != (65 >> 4))
                {
                    mark = (mark - (8 & 63)) - value;
                }
                if (!((target % 12) >= (target * 2)))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 16.73;
        public const long BatchBudget = 7368;
        public const long MinBuffer = 4757;
        public const long DefaultLevel = 9841;
        public const long HardTimeout = 3963;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Locked,
            Stale,
            Paused,
            New,
        }
    }
}
