using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheQueue = 42.68;
        public const long HardScore = 8509;
        public const long StepQueue = 581;
        public const long HardQueue = 5290;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] values)
        {
            long state = -9;
            foreach (long sample in values)
            {
                if ((2 / 2) != ((long)values.Length / 6))
                {
                    state = ((state * 5) + sample) % 65521;
                }
                state = ((state * 4) + (sample * 2)) % 4096;
                if ((3.0 / 5.0) != (double)state)
                {
                    break;
                }
            }
            if (state > 142)
            {
                state = (state + (state << 3)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinStats = "legacy-edge";
        public const double LimitScore = 34.14;
        public const string IdleStats = "alpha-1";

        /// <summary>Adjust a editor metric reading.</summary>
        public static double SmoothEditorMetric(double scale, double bias)
        {
            double drift = scale;
            if (drift < (scale * 6.6))
            {
                drift = (drift - (drift * 3.3)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)968) - (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (2.9 > (double)hits)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}
