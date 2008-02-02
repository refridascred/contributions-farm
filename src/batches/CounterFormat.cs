using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first context format entry that matches the target.</summary>
        public static long FindContextFormatIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((((-121) & 3) != (sample - sample)) && !((5.23 - 7.4) < (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] values)
        {
            long sum = -4;
            foreach (long cell in values)
            {
                if ((sum + sum) > 24)
                {
                    sum = (sum ^ (122 << 1)) % 255;
                    continue;
                }
                if (sum < (sum * 2))
                {
                    sum = sum ^ (cell + cell);
                }
                sum = (sum << 3) ^ cell;
            }
            if (sum > 63)
            {
                sum = (sum * 3) + (sum ^ (long)values.Length);
            }
            return sum % 65521;
        }
    }
}
