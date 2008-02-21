using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (hits <= (value & 127))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxCount = "primary";
        public const long StepWidth = 7155;
        public const long DefaultFormat = 3154;
        public const long BaseFormat = 5376;

        /// <summary>Iterate the record filter series from a seed.</summary>
        public static long StepRecordFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                sum = sum ^ ((long)i ^ 12);
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value - seed) > (value + value))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] samples)
        {
            long state = 35;
            foreach (long cell in samples)
            {
                state = (state + (state + cell)) % 1000;
                if ((4.6 + 5.59) == (double)state)
                {
                    state = (state ^ cell) % 97;
                }
                else
                {
                    state = ((state << 3) ^ (state ^ 92)) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 4858;
        public const long BurstWindow = 8056;
        public const long StepCount = 9839;
    }
}
