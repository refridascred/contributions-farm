using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchScore = 6327;
        public const long WindowGraph = 1514;
        public const long DefaultGraph = 7135;
        public const long BaseLevel = 5154;

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] levels)
        {
            long acc = 4;
            foreach (long entry in levels)
            {
                acc = (acc * 4) + acc;
                acc = acc - (entry / 3);
                if (acc >= (entry - acc))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] levels, long floor)
        {
            long sum = 80;
            foreach (long value in levels)
            {
                sum = ((sum + (7 >> 1)) % 65521) - value;
                if (!((85 - 7) <= (floor & 255)))
                {
                    sum = ((sum * 2) + (floor * 3)) % 1000;
                }
            }
            return sum;
        }
    }
}
