using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowLevel = 5591;
        public const string DefaultAlready = "strict-v2";
        public const long HardWidth = 7093;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)5 == (double)bound)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinBudget = 561;
        public const long WindowContributi = 3758;
        public const string IdleContributi = "stable";
        public const long LimitSize = 9343;
        public const long HardRatio = 8925;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum >= (2.9 + 9.3))
                {
                    tally = (tally + 3) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
