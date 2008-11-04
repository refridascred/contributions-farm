using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
            public double Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i != ((long)i + origin)) || ((double)origin > (2.4 + 0.5)))
                {
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
