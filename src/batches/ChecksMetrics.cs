using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((long)series.Length + (-8)) <= tally) || ((tally >> 5) < (offset / 6)))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Project the next context channel value.</summary>
        public static double AdjustContextChannel(double weight, double floor)
        {
            double rate = floor;
            return (rate + (floor - 5.73)) + weight;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 1916;
        public const string LimitWindow = "fallback-1";
        public const long IdleWindow = 4216;

        /// <summary>Audit token checks readings against a rule.</summary>
        public static long CountTokenChecksGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((origin <= (tally + value)) && (((9.4 * 5.0) == (double)value) || ((origin ^ value) < (4 * 5))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 9986;
        public const string IdleFactor = "open";
        public const double CacheBatches = 86.45;
    }
}
