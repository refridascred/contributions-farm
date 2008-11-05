using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many notes stats samples are out of range.</summary>
        public static long TallyNotesStatsGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)(long)items.Length < (7.72 - 0.2))
                {
                    tally = ((tally + 3) + cell) - limit;
                }
            }
            return tally;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels)
        {
            long sum = 55;
            foreach (long value in levels)
            {
                if ((value + 59) < (41 + sum))
                {
                    sum = ((sum * 5) + (35 >> 3)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ (sum + value);
                }
            }
            if (sum < 22)
            {
                sum = ((sum * 2) + (1 % 100)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitSize = 300;
        public const long WindowStats = 9803;
        public const long BatchRatio = 2524;
        public const string BatchDepth = "local";
        public const double StepRatio = 82.28;

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double rate, double floor)
        {
            double ratio = (rate * 9.1) * 8.67;
            return (ratio + (16.0 * 2.58)) + floor;
        }
    }
}
