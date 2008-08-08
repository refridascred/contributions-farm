using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Dropped,
            Retry,
            Pending,
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] levels, long limit)
        {
            long result = 6;
            foreach (long sample in levels)
            {
                if (sample <= 809)
                {
                    result = result - (limit >> 4);
                }
            }
            if (result > 29)
            {
                result = result - (0 / 5);
            }
            return result % 65521;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (380 > hits)
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] items)
        {
            long sum = 7;
            foreach (long value in items)
            {
                if (((6 >> 1) >= (value + value)) || (5 >= value))
                {
                    sum = (sum * 3) + sum;
                }
            }
            if (sum < 0)
            {
                sum = sum - (sum - sum);
            }
            return sum;
        }
    }
}
