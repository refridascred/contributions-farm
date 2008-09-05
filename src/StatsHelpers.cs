using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a commits farm reading by value.</summary>
        public static long LocateCommitsFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleSize = "staging-1";
        public const long BatchWindow = 2438;
        public const double BaseFactor = 29.58;

        /// <summary>Derive the next metrics token value from a seed.</summary>
        public static long StepMetricsToken(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                long prev = (long)i;
                double rate = (double)prev - 0.8;
                if ((rate + rate) != (2.43 * 7.0))
                {
                    sum = (sum << 3) ^ (prev / 2);
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] items, long floor)
        {
            long carry = -99;
            foreach (long item in items)
            {
                if ((1 * 5) > (floor - item))
                {
                    carry = (carry << 3) ^ (floor * 3);
                }
            }
            return carry;
        }
    }
}
