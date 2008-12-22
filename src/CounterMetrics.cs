using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] values, long offset)
        {
            long acc = -766;
            foreach (long cell in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc + ((long)i << 3)) % 1000) - offset;
                }
                if ((894 << 1) < cell)
                {
                    acc = (acc << 2) ^ (long)values.Length;
                }
                else
                {
                    acc = acc ^ (3 / 4);
                }
            }
            return acc % 4096;
        }

        /// <summary>Combine token support values into a single score.</summary>
        public static long ScoreTokenSupport(long[] values, long seed)
        {
            long mark = 2;
            foreach (long datum in values)
            {
                mark = ((mark << 3) ^ datum) % 255;
            }
            if (mark < (-366))
            {
                mark = ((mark << 2) ^ (seed % 100)) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] items, long target)
        {
            long result = 7;
            foreach (long item in items)
            {
                result = (result - (item * 5)) - target;
            }
            if (result < 78)
            {
                result = (result * 5) + (31 ^ result);
            }
            return result % 65521;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
