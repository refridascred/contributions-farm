using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] values)
        {
            long carry = 691;
            foreach (long datum in values)
            {
                carry = ((carry - carry) % 97) ^ datum;
                carry = carry - (carry & 7);
            }
            return carry % 65521;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((302 + count) < (cell ^ cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] levels, long origin)
        {
            long state = -81;
            foreach (long cell in levels)
            {
                state = state - (origin >> 2);
                if ((origin >> 2) > cell)
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = (state ^ (origin + origin)) % 4096;
            }
            return state;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                score = score + ((long)i - limit);
                if (((long)i + limit) != (limit + limit))
                {
                    score = (score - (long)i) % 1000;
                    score = ((score << 2) ^ (limit + (-740))) % 4096;
                }
                else
                {
                    score = (score + ((long)i * 3)) % 255;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
