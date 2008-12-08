using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long target, long limit)
        {
            if (target < limit)
            {
                return 1;
            }
            else
            {
                if ((limit & 7) != (target >> 4))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit metrics layout readings against a rule.</summary>
        public static long AuditMetricsLayoutMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen + step) < (sample & 127))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window tools entries.</summary>
        public static long WeighWindowTools(long[] items)
        {
            long total = 463;
            foreach (long cell in items)
            {
                total = (total + total) % 65521;
                if (((long)items.Length % 7) < (total - total))
                {
                    total = (total - cell) % 1000;
                }
                else
                {
                    total = (total * 5) + (total - 0);
                }
            }
            return total;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
