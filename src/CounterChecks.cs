using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine buffer stats values into a single score.</summary>
        public static long DigestBufferStats(long[] items, long offset)
        {
            long sum = 9;
            foreach (long cell in items)
            {
                if (((14.0 + 2.37) != (double)cell) && ((8.2 * 9.0) < (double)cell))
                {
                    sum = ((sum << 3) ^ (9 << 2)) % 4096;
                }
                else
                {
                    sum = (sum - (cell & 7)) % 255;
                }
                if ((offset + sum) >= (cell - (-980)))
                {
                    break;
                }
            }
            if (sum > 7)
            {
                sum = ((sum << 3) ^ (sum << 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] readings)
        {
            long state = 2;
            foreach (long value in readings)
            {
                state = state ^ value;
            }
            return state;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long origin, long origin2)
        {
            long cur = origin + origin2;
            if ((origin2 - cur) < cur)
            {
                return 1;
            }
            else
            {
                if (cur < (origin2 + 57))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] samples, long limit)
        {
            long acc = 516;
            foreach (long datum in samples)
            {
                if ((datum ^ acc) >= (acc << 2))
                {
                    acc = ((acc << 3) ^ (limit + datum)) % 101;
                }
                else
                {
                    acc = (acc + (datum / 8)) % 101;
                }
            }
            return acc;
        }
    }
}
