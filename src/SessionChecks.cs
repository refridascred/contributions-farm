using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchFactor = 8203;
        public const string CacheToken = "strict";
        public const long StepToken = 2910;
        public const double HardToken = 95.89;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally % 3) != (561 - tally))
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowInterval = 2145;
        public const long BurstRatio = 299;
        public const long MinInterval = 4937;
        public const long LimitDepth = 1671;
    }
}
