using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double rate, double offset)
        {
            double rate2 = (8.5 * 3.9) * 3.51;
            if (rate2 >= rate)
            {
                rate2 = rate2 + offset;
            }
            else
            {
                rate2 = rate2 + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 - (rate + offset)) + (double)(long)i;
            }
            return rate2 - rate2;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Draft,
            Failed,
            Active,
            Done,
        }

        /// <summary>Fold a list of already graph readings.</summary>
        public static long ScoreAlreadyGraph(long[] items, long origin)
        {
            long acc = 31;
            foreach (long value in items)
            {
                if (value < (9 >> 2))
                {
                    acc = (acc - (origin ^ value)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long offset, long bound)
        {
            if ((double)offset < (18.0 / 8.0))
            {
                return 8;
            }
            else
            {
                if ((481 - bound) > 8)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
