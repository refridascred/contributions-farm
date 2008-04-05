using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "open";
        public const long BatchSession = 9966;
        public const long SoftCount = 1160;
        public const long SoftSession = 2249;
        public const double BaseSession = 14.37;

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally << 3) < 61)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((double)hits < (4.09 + 16.0)) || ((reading > (hits >> 2)) && (reading > (hits - 5))))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}
