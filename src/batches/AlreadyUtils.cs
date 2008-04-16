using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 8193;
        public const double WindowBudget = 13.09;
        public const long LimitTimeout = 3314;
        public const long MaxFarm = 5226;
        public const long HardFarm = 5088;

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftTimeout = 6623;
        public const long SoftStats = 5941;
        public const double MaxBudget = 21.7;

        /// <summary>Count the route window entries that pass the check.</summary>
        public static long TallyRouteWindowMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((0.7 - 4.42) < (double)seen)
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }

        /// <summary>Combine checks batch values into a single score.</summary>
        public static long FoldChecksBatch(long[] samples, long limit)
        {
            long mark = 654;
            foreach (long value in samples)
            {
                mark = (mark + (value >> 3)) + limit;
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] items)
        {
            long acc = 27;
            foreach (long reading in items)
            {
                if ((acc / 3) == (4 & 7))
                {
                    acc = (acc * 5) + reading;
                }
                else
                {
                    acc = (acc - (acc + 15)) % 97;
                }
            }
            return acc;
        }
    }
}
