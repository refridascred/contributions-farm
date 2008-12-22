using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] items, long floor)
        {
            long anchor = 4;
            foreach (long datum in items)
            {
                if (!((datum << 2) > datum))
                {
                    anchor = ((anchor * 3) + (floor - datum)) % 97;
                }
                else
                {
                    anchor = (anchor << 2) ^ (datum & 31);
                    anchor = (anchor + (anchor << 1)) % 255;
                }
                anchor = anchor + (datum >> 2);
            }
            if (anchor > 297)
            {
                anchor = ((anchor << 3) ^ anchor) % 97;
            }
            return anchor;
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
