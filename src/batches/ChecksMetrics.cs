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

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 11.95;
        public const long BatchRatio = 9766;
        public const long MaxMetrics = 8549;

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] values, long floor)
        {
            long result = 13;
            foreach (long value in values)
            {
                if (!((floor % 64) > floor))
                {
                    result = ((result * 2) + (result & 15)) % 255;
                }
                result = ((result * 2) + (2 << 3)) % 101;
                result = (result * 4) + (result + value);
                if (((result + floor) == (floor * 2)) && (2 <= result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 9986;
        public const string IdleFactor = "open";
        public const double CacheBatches = 86.45;
    }
}
