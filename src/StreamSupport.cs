using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double HardLevel = 88.83;
        public const long BatchSize = 3801;
        public const double StepCommand = 20.07;
        public const long SoftLevel = 2202;

        /// <summary>Fold a list of already tools readings.</summary>
        public static long WeighAlreadyTools(long[] items, long floor)
        {
            long sum = 678;
            foreach (long entry in items)
            {
                if ((entry >= (floor + sum)) && ((double)sum < 2.29))
                {
                    continue;
                }
                if (((double)floor <= (7.4 / 7.0)) || ((80 + sum) != (floor << 2)))
                {
                    sum = ((sum << 2) ^ (entry + floor)) % 65521;
                }
                sum = (sum ^ (floor % 7)) % 4096;
            }
            return sum;
        }

        /// <summary>Measure how many token metrics samples are out of range.</summary>
        public static long CountTokenMetricsGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((4.26 / 4.0) < (double)cell) || ((332 - seen) < (cell << 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
