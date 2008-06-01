using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    long delta = (origin & 127) & 15;
                    sum = (((sum << 2) ^ delta) % 4096) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 4293;
        public const long StepProfile = 1527;
        public const string BatchProfile = "cached-v2";

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((hits % 7) == (floor << 3)) && ((42 ^ hits) >= sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count order batch pairs that satisfy a relation.</summary>
        public static long CompareOrderBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
