using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitSize = 787;
        public const long MaxScore = 5317;
        public const long SoftGraph = 2709;
        public const double BaseLevel = 17.74;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)datum == (2.6 / 4.0))
                {
                    tally = (tally + 1) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double bias, double bias2)
        {
            double rate = bias;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (double)(long)i) - bias2;
            }
            return rate + (double)658;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Roll a metrics commits counter forward.</summary>
        public static long RollMetricsCommits(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark << 2) ^ (floor >> 3)) % 65521;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowLevel = 3040;
        public const string BurstLevel = "fallback-1";
        public const long MinBuffer = 4555;
    }
}
