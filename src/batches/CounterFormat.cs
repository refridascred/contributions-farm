using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank report layout input into a small class.</summary>
        public static long RankReportLayout(long origin, long target)
        {
            long bound = origin + target;
            if (origin >= (target >> 2))
            {
                return 4;
            }
            else
            {
                if (!((origin * 3) >= bound))
                {
                    return 7;
                }
                else
                {
                    if ((double)target < (6.01 / 5.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin - target) > (bound + bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
