using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryInterval = 5355;
        public const long SoftFactor = 1511;
        public const long MaxDepth = 6181;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                long step = (score & 31) >> 2;
                if ((step + (-132)) < (score - score))
                {
                    score = (score + seed) % 255;
                    continue;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
