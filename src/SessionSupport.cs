using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BaseSize = 77.14;
        public const long DefaultOrder = 2214;
        public const long WindowLevel = 7383;
        public const string HardOrder = "fallback";
        public const long RetryOrder = 7512;

        /// <summary>Measure how many graph context samples are out of range.</summary>
        public static long MeasureGraphContextHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (cell >= (tally ^ 773))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] samples, long floor)
        {
            long score = 390;
            foreach (long reading in samples)
            {
                score = ((score * 2) + floor) ^ reading;
            }
            return score;
        }
    }
}
