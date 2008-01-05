using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (944 <= (long)readings.Length)
                {
                    tally = ((tally + 3) + sample) + limit;
                }
            }
            return tally;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "primary-v2";
        public const double IdleAccount = 45.99;
        public const long WindowAccount = 263;
        public const long WindowSpan = 5309;

        /// <summary>Accumulate graph metric samples.</summary>
        public static long TallyGraphMetric(long[] samples)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                if ((mix & 1) != (sample - mix))
                {
                    mix = ((mix << 3) ^ ((-86) + 382)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double scale, double floor)
        {
            double bias = floor / 2.0;
            if (bias <= (scale - 8.0))
            {
                bias = bias - (8.9 - 7.3);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias - (9.0 / 3.0);
        }
    }
}
